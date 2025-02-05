using System;
using Spine.Unity;
using UnityEngine;

public class UIPopup_UnlockCollection_CardSet_Pack : MonoBehaviour
{
	public RectTransform rectPack;

	public SkeletonGraphic skePack;

	public SkeletonGraphic skePackAppear;

	public BoneFollowerGraphic boneSkePack;

	public RectTransform rectCard;

	public UIPopup_UnlockCollection_CardSet_Item[] cards;

	private DataOpenCollectionPack c_data;

	private bool _isSetUp;

	public void SetUpdata()
	{
	}

	public void Init(DataOpenCollectionPack data)
	{
	}

	public void Close_Animation()
	{
	}

	public void Open_Animation(Action onComplete)
	{
	}

	public void SkipAnimation(UIChest_PatternPositionReward_Item pattern)
	{
	}

	public void PushCard_Animation(UIChest_PatternPositionReward_Item pattern, Action onComplete)
	{
	}

	private int IndexPattern()
	{
		return 0;
	}

	public void FlipCardPremium_Animaton(Action<int, UIPopup_UnlockCollection_CardSet_Item> onItemPremiumDisappear, Action onComplete)
	{
	}

	public void Out_Animation(Action<int, UIPopup_UnlockCollection_CardSet_Item> onItemDisappear, Action onComplete)
	{
	}
}
