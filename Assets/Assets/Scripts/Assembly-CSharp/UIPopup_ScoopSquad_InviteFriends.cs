using System;
using System.Collections.Generic;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_ScoopSquad_InviteFriends : MonoBehaviour
{
	[Serializable]
	public class DataUserInfo
	{
		public int type;

		public UserSimpleInfo userInfo;
	}

	public InputField inputFieldName;

	public Button btnRemoveField;

	public Button btnSearch;

	public LoopGridView gridScrollView;

	public UIPanel_TimeOutLoading rectLoading;

	public RectTransform rectEmpty;

	public Button btnInviteTeam;

	public Button btnInviteTeamLock;

	public UITimerCountdownTMP timerInviteTeamLock;

	private bool initGridView;

	private List<DataUserInfo> c_data;

	private int c_IndexSlot;

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

	private void OnInviteTeam(int status)
	{
	}

	private void OnGetFriendSuggest()
	{
	}

	private void OnGetFriendSuggest((List<UserSimpleInfo> pendings, List<UserSimpleInfo> friends, List<UserSimpleInfo> suggest) data)
	{
	}

	private void UpdateUI_Scroll(List<DataUserInfo> data)
	{
	}

	private LoopGridViewItem InitGridView(LoopGridView view, int itemIndex, int arg3, int arg4)
	{
		return null;
	}

	public void UpdateUI(int indexSlot)
	{
	}
}
