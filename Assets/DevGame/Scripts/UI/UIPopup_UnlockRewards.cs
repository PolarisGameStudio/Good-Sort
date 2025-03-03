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
	private SkeletonGraphic c_SkeChest;
	private float c_ScaleChestEnd;
	private List<ResourceValue> c_dataReward;

	private void OnEnable()
	{
        btnClaim.onClick.RemoveAllListeners();
		btnClaim.onClick.AddListener(() => {
			//viet con claim
			onClose();
        });

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

	public void UpdateUI_SkeletonChest(SkeletonGraphic skeChest, List<ResourceValue> dataReward, float scaleChestStart, float scaleChestEnd = 1f, float timeMove = 0.25f)
	{
        c_dataReward = dataReward;
        skeChest.gameObject.SetActive(true);
        skeChest.transform.parent = rectChest;
        skeChest.transform.localScale = Vector3.one * scaleChestStart;
        skeChest.transform.DOScale(Vector3.one * scaleChestEnd, timeMove).SetEase(Ease.InOutBack);
        skeChest.GetComponent<RectTransform>().DOLocalMove(Vector3.zero, timeMove).OnComplete(() => {
            skeChest.AnimationState.SetAnimation(0, "Open", false);
			StartCoroutine(IEOpenChest(dataReward, skeChest.transform.position));
        });
    }

    private IEnumerator IEOpenChest(List<ResourceValue> dataReward, Vector3 pointChes)
    {
        yield return new WaitForSeconds(1.25f);
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
			var img = icon.GetComponent<Image>();
			img.sprite = UISpriteController.Instance.GetIconMasterPassChest(dataReward[i].type);
			img.SetNativeSize();
        }

        p.DOScale(Vector3.one, 0.25f).SetEase(Ease.InOutBack);
		p.DOMove(pBegin, 0.25f).OnComplete(() => { 

		});
    }

    public void UpdateUI(RectTransform targetSpawn, List<ResourceValue> dataReward)
	{

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
