using DG.Tweening;
using Firebase.Analytics;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_InGame_PowerUp : MonoBehaviour
{
    public static UI_InGame_PowerUp instance;

	public Button[] btnSelects;

	public Image[] icons;

	public TextMeshProUGUI[] txtNumbers;

    public TextMeshProUGUI[] txtLevelLock;

    public RectTransform[] rectIconMores;

	public RectTransform[] rectIconLocks;

	public RectTransform[] rectIconFrees;

    [SerializeField] SO_PowerItem sO_PowerItem;
    public TextMeshProUGUI txtLock;
    Vector3 pointBegin = Vector3.zero;
    private Tween tween;
    private Tween tween1;
    private RectTransform rectToas = null;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
	{

        rectToas = txtLock.transform.parent.GetComponent<RectTransform>();
        pointBegin = rectToas.anchoredPosition;
        UpdateUI_SlotPowerUp(PowerupKind.BreakItem);
        UpdateUI_SlotPowerUp(PowerupKind.Swap);
        UpdateUI_SlotPowerUp(PowerupKind.Replace);
        UpdateUI_SlotPowerUp(PowerupKind.Freeze);
        AddEventClick();

    }

    private void AddEventClick()
	{
        Action<bool> callbackStart = isEnd => {
            LogicGame.Instance.IsStarPower = isEnd;
        };

        btnSelects[(int)PowerupKind.BreakItem].onClick.AddListener(() =>
        {
            if (LogicGame.Instance.IsUseSkillGame)
            {
                return;
            }
            Action<bool> callback = isSucess => {
                if (isSucess)
                {
                    OnSucess(PowerupKind.BreakItem);
                    LogicGame.Instance.OnSkillBreakItem(false);
                }
            };
            if (IsLockPower(PowerupKind.BreakItem, callback, callbackStart))
            {
                return;
            }
            callback?.Invoke(true);
        });

        btnSelects[(int)PowerupKind.Replace].onClick.AddListener(() =>
        {
            if (LogicGame.Instance.IsUseSkillGame)
            {
                return;
            }

            Action<bool> callback = isSucess => {
                if (isSucess)
                {
                    OnSucess(PowerupKind.Replace);
                    LogicGame.Instance.OnPlayAnimationReplay();
                }
            };

            if (IsLockPower(PowerupKind.Replace, callback, callbackStart))
            {
                return;
            }
            callback?.Invoke(true);
        });

        btnSelects[(int)PowerupKind.Freeze].onClick.AddListener(() =>
        {
            if (LogicGame.Instance.IsUseSkillGame)
            {
                return;
            }

            Action<bool> callback = isSucess => {
                if (isSucess)
                {
                    OnSucess(PowerupKind.Freeze);
                    LogicGame.Instance.OnSkilFreeze();
                }
            };

            if (IsLockPower(PowerupKind.Freeze, callback, callbackStart))
            {
                return;
            }
            callback?.Invoke(true);

        });

        btnSelects[(int)PowerupKind.Swap].onClick.AddListener(() =>
        {
            if (LogicGame.Instance.IsUseSkillGame)
            {
                return;
            }

            Action<bool> callback = isSucess => { 
                if(isSucess)
                {
                    OnSucess(PowerupKind.Swap);
                    LogicGame.Instance.OnSkillSwap();
                }    
            };

            if(IsLockPower(PowerupKind.Swap, callback, callbackStart))
            {
                return;
            }
            callback?.Invoke(true);
        });

    }

    bool IsLockPower(PowerupKind kind, Action<bool> callback, Action<bool> callbackStart)
    {
        var da = sO_PowerItem.GetDataPowerItem(kind);
        if (da.LevelShow > HelperManager.DataPlayer.LevelID + 1)
        {
            txtLock.text = $"Unlocked at Level {da.LevelShow}!";
            RunActionUnLock();
            return true;
        }

        if(HelperManager.GetNumPower(kind) <= 0)
        {
            UIPopup_InGame_PowerUp_GetMore.Show();
            UIPopup_InGame_PowerUp_GetMore.Instance.UpdateUI(sO_PowerItem.GetDataPowerItem(kind), callback, callbackStart);
            return true;
        }    

        return false;
    }

    void RunActionUnLock()
    {
        if (tween1 != null || tween != null)
        {
            tween1.Kill();
            tween.Kill();
            tween = null;
            tween1 = null;
        }

        rectToas.gameObject.SetActive(true);
        rectToas.transform.localScale = Vector3.one * 0.75f;
        var pointSet = pointBegin + new Vector3(0, -150, 0);
        rectToas.anchoredPosition = pointSet;

        float time = 0.25f;

        tween = rectToas.transform.DOScale(1.0f, time).SetEase(Ease.InOutBack);
        tween1 = rectToas.DOAnchorPos(pointBegin, time).SetEase(Ease.InOutQuad).OnComplete(() => {
            StartCoroutine(DisableToas());
        });
    }

    IEnumerator DisableToas()
    {
        yield return new WaitForSeconds(0.25f);
        rectToas.gameObject.SetActive(false);
    }

    private void UpdateUI_SlotPowerUp(PowerupKind kind)
    {
        var numUse = HelperManager.GetNumPower(kind);
        var daPowerItem = sO_PowerItem.GetDataPowerItem(kind);
        bool isLock = daPowerItem.LevelShow > HelperManager.DataPlayer.LevelID + 1;

        var icon = icons[(int)kind];
        var txt = txtNumbers[(int)kind];
        var iconMore = rectIconMores[(int)kind];
        var iconLock = rectIconLocks[(int)kind];
        var iconFree = rectIconFrees[(int)kind];

        icon.gameObject.SetActive(!isLock);
        iconLock.gameObject.SetActive(isLock);
        if (isLock)
        {
            var txtLock = txtLevelLock[(int)kind];
            txtLock.text = "Level " + daPowerItem.LevelShow;
            return;
        }
        
        if(numUse <= 0)
        {
            iconMore.gameObject.SetActive(true);
            txt.transform.parent.gameObject.SetActive(false);
            return;
        }
        else
        {
            iconMore.gameObject.SetActive(false);
            txt.transform.parent.gameObject.SetActive(true);
        }

        txt.text = numUse.ToString();
        txt.transform.parent.gameObject.SetActive(true);
    }

    public void OnSucess(PowerupKind kind, bool isAdd = false, int price = 1)
    {
        var keyFirst = "key_first_" + kind.ToString();
        if(PlayerPrefs.GetInt(keyFirst, 0) == 0)
        {
            /*Parameter[] lst = new Parameter[]
                 {
                        new Parameter(kind.ToString() + "_1st", HelperManager.DataPlayer.LevelID + 1),
                 };
            FirebaseLogHandle.LogEvent("Booster", lst);*/
            PlayerPrefs.SetInt(keyFirst, 1);
        }

        switch (kind)
        {
            case PowerupKind.BreakItem:
                {
                    HelperManager.DataPlayer.PowerBreakItem = HelperManager.DataPlayer.PowerBreakItem + (isAdd ? 1 : -1);
                    if (HelperManager.DataPlayer.PowerBreakItem <= 0)
                    {
                        HelperManager.DataPlayer.PowerBreakItem = 0;
                    }
                    break;
                }
            case PowerupKind.Freeze:
                {
                    HelperManager.DataPlayer.PowerFreeze = HelperManager.DataPlayer.PowerFreeze + (isAdd ? 1 : -1);
                    if (HelperManager.DataPlayer.PowerFreeze <= 0)
                    {
                        HelperManager.DataPlayer.PowerFreeze = 0;
                    }
                    break;
                }
            case PowerupKind.Replace:
                {
                    HelperManager.DataPlayer.PowerReplay = HelperManager.DataPlayer.PowerReplay + (isAdd ? 1 : -1);
                    if (HelperManager.DataPlayer.PowerReplay <= 0)
                    {
                        HelperManager.DataPlayer.PowerReplay = 0;
                    }
                    break;
                }
            case PowerupKind.Swap:
                {
                    HelperManager.DataPlayer.PowerSwap = HelperManager.DataPlayer.PowerSwap + (isAdd ? 1 : -1);
                    if (HelperManager.DataPlayer.PowerSwap <= 0)
                    {
                        HelperManager.DataPlayer.PowerSwap = 0;
                    }
                    break;
                }
        }
        UpdateUI_SlotPowerUp(kind);
    }


    private void OnPurchaseSusscess(string obj)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnUILoadingDone()
	{
	}

	private void UpdateUI()
	{
	}


	private int GetIndexPowerUp(PowerupKind kind)
	{
		return 0;
	}

	private void UpdateUI_LockItem(PowerupKind kind)
	{
	}
}
