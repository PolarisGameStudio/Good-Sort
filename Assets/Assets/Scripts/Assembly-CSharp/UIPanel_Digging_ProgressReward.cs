using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_Digging_ProgressReward : MonoBehaviour
{
	public static UIPanel_Digging_ProgressReward_Item s_ItemPreLevel;

	public UIPanel_Digging_ProgressReward_Item[] items;

	public UIPanel_Digging_ProgressReward_Item itemLast;

	public RectTransform rectBGItemLast;

	public Slider sliderProgress;

	public RectTransform rectSliderProgressReward;

	public RectTransform rectSliderItemsReward;

	public UITimerCountdownTMP timer;

	[Header("Info Reward Frame")]
	public RawImage avatarGrandReward;

	public UIRect_Profile_FrameAvatar rectFrameGrandReward;

	[Header("Ref")]
	public TextMeshProUGUI refTextCurrentLevel;

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
