using System.Collections.Generic;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

public class UILeaderboard_Players : MonoBehaviour
{
	public ScrollRect scrollRect;

	public LoopGridView gridScrollView;

	public UILeaderboard_Players_Item itemMine;

	public RectTransform rectMaskViewport;

	public RectTransform rectLoading;

	public RectTransform rectEmpty;

	public RectTransform uiPanelMaster;

	[Header("Ref")]
	public UILeaderboard_NavType refNavType;

	private bool initGridView;

	private float yScrollRect;

	private List<int> lstIndexTeamBattleInfo;

	private bool isFirstPing;

	private bool isUpdateOnValueChangeScrollRect;

	private int _curIndex;

	private GetDataByPage<UserInfoLeaderboard> _data;

	private List<UserInfoLeaderboard> _userInfoLeaderboardsCache;

	private UserInfoLeaderboard c_myInfoLeaderboard;

	private List<UserInfoLeaderboard> c_data;

	private bool isCanNextPage;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGetTopUserWorld()
	{
	}

	private void OnGetTopUserCountry()
	{
	}

	private void FirstPingValueChangeScrollRect()
	{
	}

	private void UpdateUI_MyDataLeaderboard(UserInfoLeaderboard myData)
	{
	}

	private void UpdateUI(int index)
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

	private void OnValueChangeScrollRect()
	{
	}
}
