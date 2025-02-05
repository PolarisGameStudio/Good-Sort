using System.Collections.Generic;
using Coffee.UIExtensions;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_CartRace_Showcase : MonoBehaviour
{
	public DOTweenAnimation bgTween;

	public RectTransform rectChest;

	public Image iconChest;

	public Sprite[] sprIconChest;

	public RectTransform rectStoreItem;

	public UIPopup_ListRewards_Item[] items;

	public UIChest_PatternPositionReward_Item pattern;

	public UIParticle fxDisapearChest;

	public UIParticle fxDisapearItemGold;

	public Button btnTapContinue;

	public void UpdateUI(RectTransform targetSpawn, List<ResourceValue> dataReward)
	{
	}
}
