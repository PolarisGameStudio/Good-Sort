using System;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_FoodDuel_ProgressReward : MonoBehaviour
{
	public static UIPanel_FoodDuel_ProgressReward_Item[] s_Items;

	public UIPanel_FoodDuel_ProgressReward_Item[] items;

	public UIPanel_FoodDuel_ProgressReward_Item itemLast;

	public RectTransform rectBGItemLast;

	public Slider sliderProgress;

	public RectTransform rectSliderProgressReward;

	public RectTransform rectSliderItemsReward;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void UpdateUI()
	{
	}

	private void SetCurrentSliderReward(int index)
	{
	}

	private void SetTweenSliderProgressReward(int index, Action OnComplete)
	{
	}

	private float GetPosAnchorX(int index, int max)
	{
		return 0f;
	}

	public void ClaimNearestReward()
	{
	}

	public void NextClaimReward(Action OnCompleteSliderProgressReward)
	{
	}
}
