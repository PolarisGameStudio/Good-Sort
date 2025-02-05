using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_MagicCauldron_ProgressReward : MonoBehaviour
{
	public static UIPanel_MagicCauldron_ProgressReward_Item s_ItemCurrentLevel;

	public UIPanel_MagicCauldron_ProgressReward_Item[] items;

	public UIPanel_MagicCauldron_ProgressReward_Item itemLast;

	public RectTransform rectBGItemLast;

	public Slider sliderProgress;

	public RectTransform rectSliderProgressReward;

	public RectTransform rectSliderItemsReward;

	public UIPanel_UnlockReward_Info panelUnlockReward;

	public UIPanel_UnlockReward_Info panelUnlockLastReward;

	[Header("Ref")]
	public TextMeshProUGUI refTextCurrentLevel;

	private void Awake()
	{
	}

	private void OnDestroy()
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

	private void UpdateUI_TextLevel(int level)
	{
	}

	private void SetCurrentSliderReward(int index)
	{
	}

	private void SetTweenSliderProgress(int index)
	{
	}

	private void SetTweenSliderProgressReward(int index, Action OnComplete)
	{
	}

	private float GetPosAnchorX(int index, int max)
	{
		return 0f;
	}
}
