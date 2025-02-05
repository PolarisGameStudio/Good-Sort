using System;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_TeamTreasure : MonoBehaviour
{
	public static Action OnCloseUI;

	public RectTransform rectTimer;

	public UITimerCountdownTMP timer;

	public Button btnHelp;

	public RectTransform rectBtnExit;

	public SkeletonGraphic skeCurtain;

	[Header("Info")]
	public RectTransform rectInfo;

	public Image avatarTeam;

	public Text txtTeamName;

	public TextMeshProUGUI txtTeamScore;

	[Header("Reward")]
	public UIPanel_TeamTreasure_Reward uiPanelReward;

	public UIPanel_TeamTreasure_Reward_Ended uiPanelRewardEnded;

	public RectTransform uiPanelFinish;

	[Header("Leaderboard")]
	public RectTransform rectMiniLeaderboard;

	public UIScrollRect_MiniLeaderboard scrollRectMiniLeaderboard;

	public RectTransform itemMine;

	public RectTransform itemHeaderWithoutContribution;

	public RectTransform rectLoading;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateUI_Reward()
	{
	}

	private void UpdateUI_SkeCurtain()
	{
	}
}
