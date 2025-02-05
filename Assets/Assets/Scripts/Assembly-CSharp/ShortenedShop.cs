using System.Collections.Generic;

public class ShortenedShop : NMSingleton<ShortenedShop>
{
	private RecommendPackData _recommendPackData;

	private const string key = "recommend_pack_data";

	private static Dictionary<ItemShopType, string> mapItemShopTypeIAP;

	private int _timesToChangePole1 => 0;

	private int _timesToChangePole2 => 0;

	protected override void Init()
	{
	}

	public void SetDataToDefault()
	{
	}

	public static List<ItemShopType> GetItemShopTypes()
	{
		return null;
	}

	public List<ItemShopType> GetListRecommendPacks()
	{
		return null;
	}

	private ItemShopType GetNearest(List<ItemShopType> pool, int givenValue)
	{
		return default(ItemShopType);
	}

	private ItemShopType? GetBiggestSmaller(List<ItemShopType> pool, ItemShopType givenPack)
	{
		return null;
	}

	private ItemShopType? GetSmallestBigger(List<ItemShopType> pool, ItemShopType givenPack)
	{
		return null;
	}

	private bool IsPurchasedSomething()
	{
		return false;
	}

	private List<ItemShopType> GetListRecommendPackWhenLtvEqual0()
	{
		return null;
	}

	private List<ItemShopType> GetValidPool(List<ItemShopType> initialPool)
	{
		return null;
	}

	private List<ItemShopType> GetListRecommendPackWhenLtvGreaterThan0()
	{
		return null;
	}

	private ItemShopType GetPole2Pack()
	{
		return default(ItemShopType);
	}

	private ItemShopType GetPole1Pack(ItemShopType pole2Pack)
	{
		return default(ItemShopType);
	}

	private ItemShopType GetPole4Pack(ItemShopType pole2Pack)
	{
		return default(ItemShopType);
	}

	private ItemShopType GetPole3Pack(ref ItemShopType pole4Pack)
	{
		return default(ItemShopType);
	}

	private int GetPriceFromItemShopType(ItemShopType itemShopType)
	{
		return 0;
	}

	private void Save()
	{
	}
}
