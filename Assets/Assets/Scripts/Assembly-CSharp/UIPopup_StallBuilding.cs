using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_StallBuilding : MonoBehaviour
{
	public static Action OnCloseUI;

	public static Action OnReadySwitchLevel;

	public static Action OnSwitchLevel;

	public static Action OnNextStepTutorial;

	public CanvasGroup canvasGroup;

	public Button btnHelp;

	public UIPopup popupHelp;

	public UITimerCountdownTMP timer;

	public TextMeshProUGUI txtTask;

	public Button btnExit;

	public UIPopup popupConfirmExit;

	public RectTransform rectLockUISwitchLevel;

	public RectTransform rectLockUIConfirmEnd;

	[Header("Leaderboard")]
	public Button btnLeaderboard;

	public RectTransform rectNotiLeaderboard;

	public UIPopup popupLeaderboard;

	[Header("Get More Envelope")]
	public Button btnGetMore;

	public TextMeshProUGUI txtEnvelope;

	public RectTransform rectX2Envelope;

	public UIPopup popupGetMoreEnvelope;

	[Header("Panel")]
	public UIPanel_StallBuilding_Decoration panelDecoration;

	public UIPanel_StallBuilding_ProgressReward panelProgressReward;

	public RectTransform panelProgressRewardComplete;

	public RectTransform panelTask;

	[Header("Finish")]
	public UIPopup popupFinish;

	[Header("Tutorial")]
	public UITutorialSystem tutorial;

	public UITutorialSystem tutorialRewardList;

	[Header("Popup Reward")]
	public UIPopup popupClaimNormalReward;

	public UIPopup popupClaimGrandReward;

	private bool c_CanPlayTutorialRewardList;

	private bool c_IsNeedConfirmFinish;

	private static UIPopup s_popupGetMoreEnvelope;

	public static void ReadySwitchLevel()
	{
	}

	public static void OpenUI_GetMoreEnvelope()
	{
	}

	public static void CloseUI_CloseGetMoreEnvelope()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
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

	private void UpdateUI_StateViewport()
	{
	}

	private void OnConfirmEnd(int currentLeaderboardRank)
	{
	}

	private void OnUnlockDecor(int arg1, int arg2)
	{
	}

	private void OnBuyEnvelope(int obj)
	{
	}

	private void OnDeSelecteDecoration()
	{
	}

	private void Action_OnReadySwitchLevel()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateUI_Task()
	{
	}

	private void UpdateUI_Envelope()
	{
	}

	private void UpdateUI_Tutorial()
	{
	}

	private void UpdateUI_Tutorial_RewardList()
	{
	}
}
