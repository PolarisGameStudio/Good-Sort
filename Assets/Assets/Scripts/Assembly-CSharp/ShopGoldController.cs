using System;

public class ShopGoldController : NMSingleton<ShopGoldController>
{
	private const string key = "shop_gold";

	public const int TIME_TO_WATCH_NEXT_ADS = 300;


	private ShopGold _shopGold;

	public Action<int> onWatchAdsGold;

	public Action<int, int> onBuyGold;

	public ShopGold ShopGold => null;

	protected override void Init()
	{
	}

	private void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	public void UpdateDataFromServer(ShopGold shopGold)
	{
	}

	public bool CanGetGoldFreeOrWatch()
	{
		return false;
	}

	public bool CanWatchAds()
	{
		return false;
	}

	public bool CanGetFreeGold()
	{
		return false;
	}

	public TimeSpan GetNextTime()
	{
		return default(TimeSpan);
	}

	public void WatchAdsToClaimGold()
	{
	}

	private void Save()
	{
	}

	public int GetGoldInstring(int index)
	{
		return 0;
	}

	public void PurchaseGoldPack(int index)
	{
	}

	public string GetPrice(int index)
	{
		return null;
	}

	public string GetProductID(int index)
	{
		return null;
	}
}
