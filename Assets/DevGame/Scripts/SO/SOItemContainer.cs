using System.Collections.Generic;
using UnityEngine;

public class SOItemContainer : Singleton<SOItemContainer>
{
	[SerializeField]
	private SOItem _sOItem;

	[SerializeField]
	private SOItemSeasonal _sOItemSeasonal;

	private Dictionary<ItemType, ItemAsset> _dicItem;

	protected override void Awake()
	{

	}

	public ItemAsset GetItemAsset(ItemType itemType)
	{
		return _sOItem.GetItemAsset(itemType);
	}

	public ItemAsset GetItemAsset(int itemType)
	{
		return GetItemAsset((ItemType) itemType);
	}

	public SOItemSeasonal GetSOItemSeasonal()
	{
		return null;
	}
}
