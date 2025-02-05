using System;
using System.Collections.Generic;
using SuperScrollView;
using UnityEngine;

public class UILeaderboard_Friends_Pending : MonoBehaviour
{
	public LoopListView2 loopListView;

	public RectTransform rectLoading;

	public RectTransform rectEmpty;

	private bool initGridView;

	private List<UserSimpleInfoWithTeam> c_data;

	public static Action onEnabeFriendPendingTab;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGetFriend()
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
