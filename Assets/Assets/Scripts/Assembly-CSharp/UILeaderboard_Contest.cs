using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SuperScrollView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UILeaderboard_Contest : MonoBehaviour
{
	[Serializable]
	public class InfoUserTop
	{
		public RawImage avatar;

		public UIRect_Profile_FrameAvatar rectFrameAvatar;

		public UIRect_Profile_Badge rectBadge;

		public Text txtName;

		public Text txtNamePremium;

		public Text txtTeam;

		public TextMeshProUGUI txtScore;

		public RectTransform rectCanClaim;

		public void UpdateUI(UserInfoLeaderboard data)
		{
		}

		public void SetBox_CanClaim()
		{
		}
	}

	[Serializable]
	public class RewardTop
	{
		public Button[] btnInfos;

		public Button btnRewardTop_1;

		public UIPanel_UnlockReward_Info infoRewardTop_1;

		public Image[] iconRewardTops_2;

		public Image[] iconRewardTops_3;

		public void UpdateUI(List<UserInfoLeaderboard> data)
		{
		}
	}

	private static Action s_OnForceNextSession;

	private bool c_IsForceNextSession;

	public Button btnHelp;

	public UIPopup popupHelp;

	public RectTransform rectLevelToUnlock;

	public RectTransform rectInfoUserTop;

	public InfoUserTop[] userTops;

	public RewardTop rewardTop;

	public RectTransform rectScrollRect;

	public LoopGridView gridScrollView;

	public RectTransform rectLoading;

	public RectTransform rectEmpty;

	private List<UserInfoLeaderboard> c_Data;

	private bool initGridView;

	public static void ForceNextSession()
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

	private void OnSignOut()
	{
	}

	private void OnSignIn(BindDataType type)
	{
	}

	private void OnDisable()
	{
	}

	private void OnLocalize()
	{
	}

	private void OnGetContest(bool reset)
	{
	}

	private void OnForceNextSession()
	{
	}

	private IEnumerator IETweenOutUserLeaderboard(Action onComplete)
	{
		return null;
	}

	private IEnumerator IETweenInUserLeaderboard(Action onComplete)
	{
		return null;
	}

	private float GetLeftScreenAnchorPosition3D()
	{
		return 0f;
	}

	private void UpdateUI()
	{
	}

	private void CheckTimeOut()
	{
	}

	private void StopCheckTimeOut()
	{
	}

	private void UpdateUI_Scroll(List<UserInfoLeaderboard> data)
	{
	}

	private LoopGridViewItem InitGridView(LoopGridView view, int itemIndex, int arg3, int arg4)
	{
		return null;
	}
}
