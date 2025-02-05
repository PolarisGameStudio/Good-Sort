using System.Collections.Generic;
using SuperScrollView;
using UnityEngine;

public class UILeaderboard_Friends_FriendsList : MonoBehaviour
{
	[SerializeField]
	public class UserInfoFriends
	{
		public int type;

		public int itemIndex;

		public UserSimpleInfoWithTeam userInfo;
	}

	public LoopListView2 loopListView;

	public RectTransform rectLoading;

	public RectTransform rectEmpty;

	private bool initGridView;

	private List<UserInfoFriends> c_data;

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

	private void OnGetFriend()
	{
	}

	private void UpdateUI_Scroll(List<UserInfoFriends> data)
	{
	}

	private LoopListViewItem2 InitListView(LoopListView2 view, int itemIndex)
	{
		return null;
	}
}
