using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_UnlockRewards_V2 : MonoBehaviour
{

	public DOTweenAnimation bgTween;

	public RectTransform rectChest;

	public Image iconChest;

	public RectTransform skeletonChest;

	public RectTransform rectStoreItem;

	public UIPopup_ListRewards_Item[] items;

	public UIChest_PatternPositionReward_Item pattern;

	public UIParticle fxDisapearChest;

	public UIParticle fxDisapearItemGold;

	public UIParticle[] fxAppears;

	public Button btnTapContinue;

	private SkeletonGraphic c_SkeChest;

	private float c_ScaleChestEnd;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void UpdateUI_IconChest(Sprite sprChest, float scaleChestStart, float scaleChestEnd = 1f)
	{
	}

	public void UpdateUI_SkeletonChest(SkeletonGraphic skeChest, float scaleChestStart, float scaleChestEnd = 1f)
	{
	}

	public void UpdateUI(RectTransform targetSpawn, List<ResourceValue> dataReward)
	{
	}

	private IEnumerator IEOpenChest(List<ResourceValue> dataReward)
	{
		return null;
	}

	private void CloseUI()
	{
	}

	private void CloseUI_Collection()
	{
	}
}
