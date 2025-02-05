using System.Collections.Generic;
using SuperScrollView;
using UnityEngine;

public class UILeaderboard_Friends_AddFriends : MonoBehaviour
{
	public LoopListView2 loopListView;

	public RectTransform rectLoading;

	public RectTransform rectEmpty;

	private bool initGridView;

	private List<UserSimpleInfoWithTeam> c_data;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGetFriendSuggest()
	{
	}

	private void UpdateUI_Scroll(List<UserSimpleInfoWithTeam> data)
	{
	}

	private LoopListViewItem2 InitListView(LoopListView2 view, int itemIndex)
	{
		return null;
	}
}
