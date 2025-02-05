using System.Collections.Generic;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_TeamBattle_MyTeam : MonoBehaviour
{
	public class DataUI_UserInfoTeamBattle
	{
		public int itemIndex;

		public UserInfoTeamBattle dataUserInfo;
	}

	public ScrollRect scrollRect;

	public LoopGridView loopGridView;

	public RectTransform maskRect;

	public RectTransform rectLoading;

	public UIPanel_TeamBattle_MyTeam_Item itemMine;

	private List<DataUI_UserInfoTeamBattle> c_DataUI_UserInfoTeamBattle;

	private List<UserInfoTeamBattle> c_DataUserInfoTeamBattle;

	private bool initScroll;

	private float yScrollRect;

	private List<int> lstIndexUserInfoTeamBattle;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGetTeamBattleInfo()
	{
	}

	private void UpdateUI_Scroll()
	{
	}

	private LoopGridViewItem InitGridView(LoopGridView view, int itemIndex, int obj1, int obj2)
	{
		return null;
	}

	private void OnValueChangeScrollRect()
	{
	}
}
