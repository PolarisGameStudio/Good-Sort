using System;
using System.Collections.Generic;
using MagicExcel;

public class ShopHallweenDataController : NMSingleton<ShopHallweenDataController>
{
	public enum ShovelShopType
	{
		Shovel_1 = 0,
		Shovel_2 = 1,
		Shovel_3 = 2
	}

	public Action<ShovelShopType> OnBuyItem;

	public Action OnRefreshNumShovel;

	public Action<List<ResourceValue>> OnBuyPack;

	protected override void Init()
	{
	}

	public string GetProductId(ShovelShopType shovel)
	{
		return null;
	}

	public string GetPrice(ShovelShopType shopType)
	{
		return null;
	}

	public int GetNumShovel(ShovelShopType shovel)
	{
		return 0;
	}

	public void Purchase(ShovelShopType shovel)
	{
	}

	public void RefreshNumShovel()
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

	public string GetBuyAllPriceNotSaleOff()
	{
		return null;
	}

	public string[] GetPrices()
	{
		return null;
	}

	public void Purchase(int index)
	{
	}

	public List<ResourceValue> GetResourceValuesInPack(int index)
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

	private List<ResourceValue> GetResourceValuesInPack_3(int index)
	{
		return null;
	}

	private List<ResourceValue> GetResourceValuesInPack(EncryptedInt[] rewardTypes, EncryptedInt[] rewardValues)
	{
		return null;
	}

	private void ConvertListResourceToDic(List<ResourceValue> resourceValues, Dictionary<int, float> dicResource)
	{
	}
}
