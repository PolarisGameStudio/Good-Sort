using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using DG.Tweening;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_UnlockRewards : Dialog<UIPopup_UnlockRewards>
{
	public DOTweenAnimation bgTween;
	public RectTransform rectChest;
	public Image iconChest;
	public RectTransform skeletonChest;
	public RectTransform rectStoreItem;
	public UIChest_PatternPositionReward_Item pattern;
	public UIParticle fxDisapearChest;
	public UIParticle fxDisapearItemGold;
	public UIParticle[] fxAppears;
	public Button btnClaim;
	public Button btnClaimX2;
    public Button btnCLose;

    private SkeletonGraphic c_SkeChest;
	private float c_ScaleChestEnd;
	private List<ResourceValue> c_dataReward;
	public GameObject objFxX2 = null;

	Dictionary<TextMeshProUGUI, float> dataTextValue = new();

	Action callbackClaim = null;

    Coroutine coroutine;

    private void Start()
    {
        btnClaim.onClick.AddListener(() => {
			callbackClaim?.Invoke();
            //viet con claim
            onClose();
        });

        btnCLose.onClick.AddListener(() => {
			callbackClaim?.Invoke();
            //viet con claim
            onClose();
        });

        btnClaimX2.onClick.AddListener(() => {

            AdsManager.Instance.ShowRewardBasedVideo((success) =>
            {
                if (success)
                {
                    foreach(var da in dataTextValue)
                    {
                        da.Key.text = (da.Value * 2).ToString();
                    }

                    AddReward();
                    StartCoroutine(OnCloseX2());
                    //viet con claim
                }
                else
                {
                    callbackClaim?.Invoke();
                    onClose();
                }
            }, "OnX2Reward");

        });

        coroutine = StartCoroutine(StartEnableBtnClaim());
    }

    IEnumerator StartEnableBtnClaim()
    {
        yield return new WaitForSeconds(4f);
        btnClaim.gameObject.SetActive(true); ;
    }

    private IEnumerator OnCloseX2()
    {
        yield return new WaitForEndOfFrame();
        Vibration.Vibrate(50);
        Audio.Play(ScStatic.SFX_In_game_Fire_word, 1.0f, false, true);
        objFxX2.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        callbackClaim?.Invoke();
        onClose();
    }

    private void OnEnable()
	{
		

    }

	private void OnDisable()
	{
	}

	private void OnWatchAdsComplete_X2Reward()
	{
	}

	public void UpdateUI_IconChest(Sprite sprChest, float scaleChestStart, float scaleChestEnd = 1f)
	{
	}

	public void UpdateUI_SkeletonChest(SkeletonGraphic skeChest, List<ResourceValue> dataReward, float scaleChestStart, float scaleChestEnd = 1f, float timeMove = 0.25f, Action complete = null)
	{
		var sk = Instantiate(skeChest, skeChest.transform.parent);
        sk.transform.position = skeChest.transform.position;

        c_dataReward = dataReward;
        sk.gameObject.SetActive(true);
        sk.transform.parent = rectChest;
        sk.transform.localScale = Vector3.one * scaleChestStart;
        sk.transform.DOScale(Vector3.one * scaleChestEnd, timeMove).SetEase(Ease.InOutBack);
        sk.GetComponent<RectTransform>().DOLocalMove(Vector3.zero, timeMove).OnComplete(() => {
            sk.AnimationState.SetAnimation(0, "Open", false);
            sk.AnimationState.AddAnimation(0, "Idle_After", true, 0);
			callbackClaim = complete;
            StartCoroutine(IEOpenChest(dataReward, sk, complete));
        });
    }

    private IEnumerator IEOpenChest(List<ResourceValue> dataReward, SkeletonGraphic skeChest, Action complete)
    {
        dataTextValue.Clear();
        Audio.Play(ScStatic.SFX_In_game_Fire_word);
        yield return new WaitForSeconds(1.75f);
		var pointChes = skeChest.transform.position;
        var p = pattern.GetPattern(dataReward.Count);
		var pBegin = p.transform.position;
		p.localScale = Vector3.one * 0.25f;
		p.transform.position = pointChes;

		for(int i = 0; i < p.childCount; i++)
		{
			var item = p.GetChild(i);
			item.gameObject.SetActive(true);
            var icon = item.GetChild(0);
			var txtValue = item.GetChild(1);
			var txtMesh = txtValue.GetComponent<TextMeshProUGUI>();
			txtMesh.text = dataReward[i].value.ToString();
            dataTextValue.Add(txtMesh, dataReward[i].value);

            txtMesh.fontSize += 20;

            txtMesh.GetComponent<RectTransform>().anchoredPosition += new Vector2(0, 29);

            var img = icon.GetComponent<Image>();
			img.sprite = UISpriteController.Instance.GetIconMasterPassChest(dataReward[i].type);
			img.SetNativeSize();
        }

        p.DOScale(Vector3.one, 0.25f).SetEase(Ease.InOutBack);
		p.DOMove(pBegin, 0.25f).OnComplete(() => {
            //complete?.Invoke();
            //skeChest.gameObject.SetActive(false);

        }).SetEase(Ease.InOutSine);

		AddReward();
    }

	private void AddReward()
	{
        foreach (var it in c_dataReward)
        {
            it.AddResourceType();
        }
    }

    public void UpdateUI_SkeletonChest_Sprite(SkeletonGraphic skeChest, List<Sprite> listSprt, float scaleChestStart, float scaleChestEnd = 1f, float timeMove = 0.25f, Action complete = null)
    {
        var sk = Instantiate(skeChest, skeChest.transform.parent);
        sk.transform.position = skeChest.transform.position;
        sk.gameObject.SetActive(true);
        sk.transform.parent = rectChest;
        sk.transform.localScale = Vector3.one * scaleChestStart;
        sk.transform.DOScale(Vector3.one * scaleChestEnd, timeMove).SetEase(Ease.InOutBack);
        sk.GetComponent<RectTransform>().DOLocalMove(Vector3.zero, timeMove).OnComplete(() => {
            sk.AnimationState.SetAnimation(0, "Open", false);
            sk.AnimationState.AddAnimation(0, "Idle_After", true, 0);
            callbackClaim = complete;
            StartCoroutine(IEOpenChest_Sprite(listSprt, sk, complete));
        });
    }

    private IEnumerator IEOpenChest_Sprite(List<Sprite> listSprt, SkeletonGraphic skeChest, Action complete)
    {
        Audio.Play(ScStatic.SFX_In_game_Fire_word);
        yield return new WaitForSeconds(1.75f);
        var pointChes = skeChest.transform.position;
        var p = pattern.GetPatternItems();
        var pBegin = p.transform.position;
        p.localScale = Vector3.one * 0.25f;
        p.transform.position = pointChes;

        for (int i = 0; i < p.childCount; i++)
        {
            var item = p.GetChild(i);
            item.gameObject.SetActive(true);
            var icon = item.GetChild(01);
            var img = icon.GetComponent<Image>();
            img.sprite = listSprt[i];
            img.SetNativeSize();
        }

        p.DOScale(Vector3.one, 0.25f).SetEase(Ease.InOutBack);
        p.DOMove(pBegin, 0.25f).OnComplete(() => {
            //complete?.Invoke();
            //skeChest.gameObject.SetActive(false);

        }).SetEase(Ease.InOutSine);
    }


    public void UpdateUISprite()
	{
        StopCoroutine(coroutine);
        coroutine = null;

        btnClaim.gameObject.SetActive(false);
        btnClaimX2.gameObject.SetActive(false);
        btnCLose.gameObject.SetActive(true);
    }

    public void UpdateUI_Claim(Action onClaim, Action onClaimX2)
	{
	}

	private void CloseUI()
	{
	}

	private void DisableButton()
	{
	}

    public static void Show()
    {
        Open();
    }
    public static void Hide()
    {
        Close();
    }
    public void onClose()
    {
        Hide();
    }
}
