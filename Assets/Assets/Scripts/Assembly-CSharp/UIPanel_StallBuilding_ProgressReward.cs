using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_StallBuilding_ProgressReward : MonoBehaviour
{
	public static UIPanel_StallBuilding_ProgressReward_Item s_ItemCurrentLevel;

	public UIPanel_StallBuilding_ProgressReward_Item[] items;

	public UIPanel_StallBuilding_ProgressReward_Item itemLast;

	public RectTransform rectBGItemLast;

	public Slider sliderProgress;

	public RectTransform rectSliderProgressReward;

	public RectTransform rectSliderItemsReward;

	public UIPanel_UnlockReward_Info panelUnlockReward;

	public UIPanel_UnlockReward_Info panelUnlockLastReward;

	public Button btnOpenListReward;

	public UIPopup popupListReward;

	private List<(int ProgressNeeded, float StartValue, float EndValue)> listProgressNeedUpdates;

	private void Awake()
	{
	}

	private void OnDestroy()
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

	private void OnReadySwitchLevel()
	{
	}

	private void OnSwitchLevel()
	{
	}

	private void UpdateUI()
	{
	}

	private void SetCurrentSliderReward(int index)
	{
	}

	private void SetTweenSliderProgress(int index, Action OnComplete)
	{
	}

	private void SetTweenSliderProgressReward(int index, Action OnComplete)
	{
	}

	private float GetPosAnchorX(int index, int max)
	{
		return 0f;
	}

	private float GetRealProgress(int CurrentProgress)
	{
		return 0f;
	}
}
