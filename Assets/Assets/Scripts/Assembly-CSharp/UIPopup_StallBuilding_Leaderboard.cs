using System;
using System.Collections.Generic;
using SuperScrollView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_StallBuilding_Leaderboard : MonoBehaviour
{
	[Serializable]
	public class UserInfoTop3
	{
		public RectTransform rectBox;

		public RectTransform rectCurrent;

		public RawImage avatar;

		public UIRect_Profile_FrameAvatar rectFrame;

		public UIRect_Profile_Badge rectBadge;

		public Text txtName;

		public Text txtNamePremium;

		public Text txtTeam;

		public TextMeshProUGUI txtScore;

		public Button btnInfo;

		public UIPopup_ListRewards_V2_Item itemReward;

		public void UpdateUI(int itemIndex, UserInfoScore data)
		{
		}
	}

	public UITimerCountdownTMP uITimerCountdown;

	public RectTransform rectTop3;

	public UserInfoTop3[] userInfoTop3s;

	public CanvasGroup canvasGroupInfoUsers;

	public ScrollRect scrollRect;

	public LoopGridView loopGridView;

	public RectTransform rectSticky;

	public RectTransform rectItemMine;

	public UIPopup_StallBuilding_Leaderboard_Item itemMine;

	public UIPanel_TimeOutLoading rectLockUI;

	private bool isInitLoopGridView;

	private List<UserInfoScore> c_data;

	private int c_page;

	private int c_maxPage;

	private bool c_loadingPage;

	private bool c_isFirstCheckOnValueChange;

	private Vector3[] viewportCorners;

	private Vector3[] itemCorners;

	private Vector3[] itemSticky;

	private int minUserToNextPage;

	private void Start()
	{
	}

	private void LateUpdate()
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

	private void OnReceivedLeaderboard()
	{
	}

	private void UpdateUI_Scroll(List<UserInfoScore> data)
	{
	}

	private void OnValueChangeScroll()
	{
	}

	private bool IsOutsideViewport()
	{
		return false;
	}

	private LoopGridViewItem OnInitGridViewItem(LoopGridView view, int itemIndex, int arg3, int arg4)
	{
		return null;
	}

	private void UpdateUI_Top3(List<UserInfoScore> data)
	{
	}
}
