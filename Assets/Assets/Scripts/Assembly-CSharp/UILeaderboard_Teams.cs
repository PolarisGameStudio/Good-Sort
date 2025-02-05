using System.Collections.Generic;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

public class UILeaderboard_Teams : MonoBehaviour
{
	public ScrollRect scrollRect;

	public LoopGridView gridScrollView;

	public UILeaderboard_Teams_Item itemMine;

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

	private GetDataByPage<TeamInfoLeaderboard> _data;

	private List<TeamInfoLeaderboard> _userInfoLeaderboardsCache;

	private TeamInfoLeaderboard c_myInfoLeaderboard;

	private List<TeamInfoLeaderboard> c_data;

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

	private void OnGetTopTeamWorld()
	{
	}

	private void OnGetTopTeamCountry()
	{
	}

	private void FirstPingValueChangeScrollRect()
	{
	}

	private void UpdateUI_MyDataLeaderboard(TeamInfoLeaderboard myData)
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

	private void UpdateUI_Scroll(List<TeamInfoLeaderboard> data)
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
