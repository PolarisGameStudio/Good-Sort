using System;
using System.Collections.Generic;
using Spine.Unity;
using SuperScrollView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_StockingChallenge : MonoBehaviour
{
	public static Action OnCloseUI;

	public static bool s_IsTweenChangeRankYourSelf;

	public UITimerCountdownTMP uITimerCountdown;

	public Button btnHelp;

	public UIPopup popupHelp;

	public RectTransform rectBGProgressIdle;

	public RectTransform[] rectBGProgressMoves;

	public RectTransform rectMaskFollowTarget;

	public SkeletonGraphic skeBoxWinStreak;

	public Slider sliderWinStreak;

	public Button btnInfoWinStreak;

	public UIPanel_StockingChallenge_InfoWinStreak panelInfoWinStreak;

	public Slider sliderReward;

	public Button[] btnRewards;

	public SkeletonGraphic[] skeIcons;

	public RectTransform[] rectTxtRewards;

	public TextMeshProUGUI[] txtRewards;

	public RectTransform[] rectCanClaimRewards;

	public SkeletonGraphic[] skeCompleteRewards;

	public UIPanel_UnlockReward_Info bubbleRewardInfo;

	public ScrollRect scrollRect;

	public UIScrollRectSnapToChild scrollSnap;

	public LoopGridView scrollGridView;

	public RectTransform maskRect;

	public CanvasGroup canvasGroupScrollViewport;

	public UIPopup_StockingChallenge_Item itemMine;

	private List<StockingUser> c_DataStockingUser;

	private bool initScroll;

	private float yScrollRect;

	private List<int> lstIndexStockingUser;

	private bool c_IsCanTweenIn;

	private int c_IndexPreYourSelf;

	private int c_IndexCurrentYourSelf;

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

	private void OnDestroy()
	{
	}

	private void UpdateUI_SkeWinStreak(bool force)
	{
	}

	private void UpdateUI_Progress()
	{
	}

	private float GetRatioFillPregressBar(int point)
	{
		return 0f;
	}

	private void UpdateUI_StateReward()
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

	private void OnValueChangeProgress()
	{
	}
}
