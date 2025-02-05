using System.Collections.Generic;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_TeamBattle_Battle : MonoBehaviour
{
	public static bool s_IsTweenChangeRankYourSelf;

	public ScrollRect scrollRect;

	public UIScrollRectSnapToChild scrollSnap;

	public LoopGridView scrollGridView;

	public RectTransform maskRect;

	public CanvasGroup canvasGroupScrollViewport;

	public RectTransform rectLoading;

	public UIPanel_TeamBattle_Battle_Item itemMine;

	private List<TeamBattleInfo> c_DataTeamBattleInfo;

	private bool initScroll;

	private float yScrollRect;

	private List<int> lstIndexTeamBattleInfo;

	private bool c_IsCanTweenIn;

	private int c_IndexPreYourSelf;

	private int c_IndexCurrentYourSelf;

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

	private LoopGridViewItem InitGridView(LoopGridView view, int itemIndex, int arg3, int arg4)
	{
		return null;
	}

	private void UpdateUI_TweenChangePoint()
	{
	}

	private void OnValueChangeScrollRect()
	{
	}
}
