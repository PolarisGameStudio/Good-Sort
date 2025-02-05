using System.Collections.Generic;
using Coffee.UIExtensions;
using Spine.Unity;
using UnityEngine;

public class UIPanel_MagicCauldron_Level_GiftToLayer : MonoBehaviour
{
	[Header("Ref")]
	public UIPanel_MagicCauldron_Level_Layer refHistoryLayerManager;

	public RectTransform refRectLockUITryResultGiftInLayer;

	public RectTransform refTargetItemFly;

	public SkeletonGraphic refSkeBanner;

	public UIParticle refFxSnow;

	public UIParticle[] refFxTargetItemFlyDisappears;

	[Header("UI")]
	public RectTransform rectPointStart;

	public RectTransform[] points;

	public RectTransform rectItems;

	public UIPanel_MagicCauldron_Level_GiftToLayer_Item[] items;

	public RectTransform rectItemReadyFlyToBanner;

	public static int c_Level;

	[HideInInspector]
	public List<int> c_DataRemainingItemOriginal;

	public static float GetScaleRatioGiftItemOriginal()
	{
		return 0f;
	}

	public static float GetScaleRatioGiftItemToLayer()
	{
		return 0f;
	}

	public static float GetScaleRatioScaleGiftItem()
	{
		return 0f;
	}

	public static Vector2 GetSizeDeltaGiftItemOriginal()
	{
		return default(Vector2);
	}

	public static Vector2 GetSizeDeltaGiftItemToLayer()
	{
		return default(Vector2);
	}

	public static Vector2 GetSizeDeltaScaleGiftItem()
	{
		return default(Vector2);
	}

	public static float GetRatioScaleViewportLayerItem()
	{
		return 0f;
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

	private void OnSwitchLevel()
	{
	}

	public void UpdateUI()
	{
	}

	private void UpdateUI_TweenInListGift()
	{
	}

	private void UpdateUI_HistoryLayer()
	{
	}
}
