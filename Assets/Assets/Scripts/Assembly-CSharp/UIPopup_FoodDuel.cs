using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_FoodDuel : MonoBehaviour
{
	public static Action OnCloseUI;

	public static RectTransform s_rectTextCurrentTicket;

	public static Button s_btnQuest;

	public CanvasGroup canvasGroup;

	public UITimerCountdownTMP uITimerCountdown;

	public Button btnHelp;

	public UIPopup popupHelp;

	public TextMeshProUGUI txtCurrentMedal;

	public TextMeshProUGUI txtCurrentTicket;

	public Button btnGetMoreTicket;

	public Button btnStart;

	public TextMeshProUGUI txtPriceTicketStart;

	public Button btnQuest;

	public RectTransform rectNotifyQuest;

	public Button btnLeaderboard;

	public RectTransform rectNavActive;

	public RectTransform rectNavFinish;

	[Header("Popup")]
	public UIPopup popupGetMoreTicket;

	public UIPopup popupLeaderboard;

	public UIPopup popupPrepareToFight;

	public UIPopup popupClaimNormalReward;

	public UIPopup popupClaimGrandReward;

	[Header("Lock UI")]
	public RectTransform rectLockUIQuest;

	public RectTransform rectLockUIProgressReward;

	[Header("Panel Extend")]
	public UIPanel_FoodDuel_Quest panelQuest;

	public UIPanel_FoodDuel_ProgressReward panelProgressReward;

	public UIPanel_FoodDuel_ProgressReward_Complete panelProgressRewardComplete;

	public RectTransform UIPanelFinish;

	public RectTransform UIPanelLeaderboardUpdate;

	private int c_currentTicket;

	private bool IsReadyToPlayPVP;

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

	private void OnEventPVPFoundMatch()
	{
	}

	private void OnClaimProgressReward(int indexReward)
	{
	}

	private void OnClaimLeaderboardReward(int indexReward)
	{
	}

	private void OnClaimQuest(int indexQuest)
	{
	}

	private void OnFlyItemToTargetComplete(ResourceType type, int numberAdd)
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateUI_Medal()
	{
	}

	private void UpdateUI_CurrentTicket()
	{
	}

	private void UpdateUI_NotifyQuest()
	{
	}

	private void UpdateUI_Finish()
	{
	}

	private void UpdateUI_LeaderboardUpdate()
	{
	}

	private void UpdateUI_Tutorial()
	{
	}
}
