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

public class UIPopup_UnlockRewards : MonoBehaviour
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

	public Button btnClaim;

	public Button btnClaimX2;

	private SkeletonGraphic c_SkeChest;

	private float c_ScaleChestEnd;

	private List<ResourceValue> c_dataReward;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnWatchAdsComplete_X2Reward()
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

	public void UpdateUI_Claim(Action onClaim, Action onClaimX2)
	{
	}

	private IEnumerator IEOpenChest(List<ResourceValue> dataReward)
	{
		return null;
	}

	private void CloseUI()
	{
	}

	private void DisableButton()
	{
	}
}
