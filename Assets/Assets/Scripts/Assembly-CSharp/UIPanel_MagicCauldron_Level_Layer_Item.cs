using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_MagicCauldron_Level_Layer_Item : MonoBehaviour
{
	[Serializable]
	public class Block
	{
		public RectTransform rectBlock;

		public RectTransform[] rectChildsInBlock;
	}

	public Block[] blocks;

	public RectTransform viewport;

	public CanvasGroup viewportCanvasGroup;

	public RectTransform rectStoreSendGift;

	[Header("State")]
	public HorizontalLayoutGroup layoutRectItemStateGifts;

	public RectTransform[] rectItemStateGifts;

	private int c_ItemIndex;

	private UIPanel_MagicCauldron_Level_Layer c_LevelLayerManager;

	private UIPanel_MagicCauldron_Level_GiftToLayer c_LevelGiftToLayerManager;

	public List<ChristmasData.OneSlotTryData> c_data;

	public void SetItemData(UIPanel_MagicCauldron_Level_Layer manager, int itemIndex, List<ChristmasData.OneSlotTryData> data)
	{
	}

	public void SetItemData_ChangeStateSlotGift(List<ChristmasData.OneSlotTryData> data, Action OnComplete)
	{
	}

	public void SetItemData_ReadyFlyToBanner(RectTransform rectStoreCloneItem)
	{
	}
}
