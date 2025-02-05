using System;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_MagicCauldron : MonoBehaviour
{
	public static Action OnCloseUI;

	public static Action OnSendGiftToLayer;

	public static Action OnRemoveGiftFromLayer;

	public static Action OnReadySwitchLevel;

	public static Action OnSwitchLevel;

	public static Action OnNextStepTutorial;

	public UIPanel_MagicCauldron_Level_GiftToLayer UIPanelLevelGiftToLayer;

	public UIPanel_MagicCauldron_CurrentGift UIPanelCurrentGift;

	public UITimerCountdownTMP timer;

	public RectTransform[] rectUIActives;

	public RectTransform rectUIFinish;

	public Button btnExit;

	public UIPopup popupConfirmExit;

	public Button btnHelp;

	public UIPopup popupHelp;

	public RectTransform rectLockUISwitchLevel;

	[Header("Popup Reward")]
	public UIPopup popupClaimNormalReward;

	public UIPopup popupClaimGrandReward;

	[Header("Tutorial")]
	public RectTransform rectBGTutorial;

	public UITutorialSystem tutorial;

	public static void SendGiftToSlot()
	{
	}

	public static void RemoveGiftFromSlot()
	{
	}

	public static void ReadySwitchLevel()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Action_OnReadySwitchLevel()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateUI_Tutorial()
	{
	}
}
