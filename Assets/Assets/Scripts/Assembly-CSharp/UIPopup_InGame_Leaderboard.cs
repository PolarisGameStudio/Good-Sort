using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using SuperScrollView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_InGame_Leaderboard : MonoBehaviour
{
	[Serializable]
	public class TopUser
	{
		public TextMeshProUGUI[] txtGolds;

		public Text[] txtNames;

		public Text[] txtNamePremiums;

		public Image[] bgAvatars;

		public Image[] avatars;

		public void UpdateUI(List<LeaderBoardUserInfo> data)
		{
		}
	}

	[Serializable]
	public class TimeRemainingConvert
	{

		public RectTransform rectTime;

		public TextMeshProUGUI txtTime;

		public RectTransform rectStar;

		public TextMeshProUGUI txtStar;

		public RectTransform[] points;

		public UIParticle fxClaim;

		private bool isShow;

		public void Default()
		{
		}

		public IEnumerator IEConvertTimeToStar(UIPopup_InGame_Leaderboard leaderboard)
		{
			return null;
		}
	}

	[Serializable]
	public class PoolFly
	{

		public RectTransform[] items;

		public RectTransform[] points;

		private WaitForSeconds wait;

		public IEnumerator IESpawnStar_TotalStar(UIPopup_InGame_Leaderboard leaderboard)
		{
			return null;
		}

		public IEnumerator IESpawnStar_LeaderboardItemMine(UIPopup_InGame_Leaderboard leaderboard)
		{
			return null;
		}

		public void Default()
		{
		}
	}

	[Header("Leaderboard")]
	public UITimerCountdownTMP timer;

	public UIScrollRectSnapToChild scrollRectSnap;

	public LoopGridView loopGridView;

	public UIPopup_InGame_Leaderboard_Item itemMine;

	public RectTransform rectLockLoopGridView;

	[Header("Top User")]
	public TopUser topUser;

	[Header("Time Convert Star")]
	public TimeRemainingConvert timeRemainingConvert;

	[Header("Star")]
	public TextMeshProUGUI txtTotalStar;

	public RectTransform pointStart;

	public UIParticle fxStarClaim;

	public UIParticle fxStarIncrease;

	public PoolFly poolFly;

	[Header("Reward")]
	public UIPanel_InGame_Leaderboard_ClaimChest uiPanelClaimChest;

	public UIPanel_InGame_Leaderboard_ClaimStar uiPanelClaimStar;

	public UIPanel_InGame_Leaderboard_PiggyBank uiPanelPiggyBank;

	private bool c_IsFirstTimeLeaderboard;

	private LeaderBoardUserInfo myLeaderboard;

	private List<LeaderBoardUserInfo> c_data;

	private bool c_initLoopGridView;

	private int c_countLoopGridView;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnWatchAdsComplete(int star)
	{
	}

	private void UpdateUI()
	{
	}

	private IEnumerator IETweenLeaderboard(Action onStarMoveDone = null)
	{
		return null;
	}

	private void InitLoopGridView()
	{
	}

	private LoopGridViewItem InitLoopGridView(LoopGridView view, int itemIndex, int row, int column)
	{
		return null;
	}
}
