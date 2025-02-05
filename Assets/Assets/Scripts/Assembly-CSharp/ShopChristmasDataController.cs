using System;
using System.Collections.Generic;
using MagicExcel;

public class ShopChristmasDataController : NMSingleton<ShopChristmasDataController>
{
	public enum GiftHiddenShopType
	{
		GiftHidden_1 = 0,
		GiftHidden_2 = 1,
		GiftHidden_3 = 2
	}

	public Action<GiftHiddenShopType> OnBuyItem;

	public Action OnRefreshNumGiftHidden;

	public Action<List<ResourceValue>> OnBuyPack;

	protected override void Init()
	{
	}

	public string GetProductId(GiftHiddenShopType giftHidden)
	{
		return null;
	}

	public string GetPrice(GiftHiddenShopType shopType)
	{
		return null;
	}

	public int GetNumGiftHidden(GiftHiddenShopType giftHidden)
	{
		return 0;
	}

	public void Purchase(GiftHiddenShopType giftHidden)
	{
	}

	public void RefreshNumGiftHidden()
	{
	}

	public bool CanBuyPack()
	{
		return false;
	}

	private int UserType()
	{
		return 0;
	}

	public string[] GetProductTypes()
	{
		return null;
	}

	public string[] GetPrices()
	{
		return null;
	}

	public string GetBuyAllPriceNotSaleOff()
	{
		return null;
	}

	public void Purchase(int index)
	{
	}

	public List<ResourceValue> GetResourceValues(int index)
	{
		return null;
	}

	public List<ResourceValue> GetResourceValuesInChest(int index)
	{
		return null;
	}

	private List<ResourceValue> GetResourceValuesInPack_0(int index)
	{
		return null;
	}

	private List<ResourceValue> GetResourceValuesInPack_1(int index)
	{
		return null;
	}

	private List<ResourceValue> GetResourceValuesInPack_2(int index)
	{
		return null;
	}

	public static List<ResourceValue> GetResourceValues(EncryptedInt[] rewardTypes, EncryptedInt[] rewardValues)
	{
		return null;
	}

	private void ConvertListResourceToDic(List<ResourceValue> resourceValues, Dictionary<int, float> dicResource)
	{
	}
}
