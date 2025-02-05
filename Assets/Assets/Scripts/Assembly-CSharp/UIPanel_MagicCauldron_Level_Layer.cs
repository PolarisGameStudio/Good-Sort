using System;
using System.Collections.Generic;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_MagicCauldron_Level_Layer : MonoBehaviour
{
	public RectTransform rectBGScroll;

	public RectTransform rectLoopGridView;

	public ScrollRect scrollRectGridView;

	public LoopGridView loopGridView;

	public UIScrollRectSnapToChild uIScrollRectSnapToChild;

	public RectTransform rectLockUI;

	private List<List<ChristmasData.OneSlotTryData>> dataHistoryLayer;

	private UIPanel_MagicCauldron_Level_GiftToLayer c_LevelGiftToLayerManager;

	private bool initLoopGridView;

	private int c_NumberHistoryLayer;

	private string c_KeyTweenLockUI;

	private bool initItemSize;

	public UIPanel_MagicCauldron_Level_GiftToLayer GetLevelGiftToLayerManager()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSendGiftToLayer()
	{
	}

	public void UpdateUI(UIPanel_MagicCauldron_Level_GiftToLayer levelGiftToLayerManager)
	{
	}

	public void UpdateUI_DataScroll()
	{
	}

	public void UpdateUI_ResetPadding()
	{
	}

	public void UpdateUI_NextLayer(Action OnUpdateUI)
	{
	}

	private LoopGridViewItem InitGridView(LoopGridView view, int itemIndex, int arg3, int arg4)
	{
		return null;
	}
}
