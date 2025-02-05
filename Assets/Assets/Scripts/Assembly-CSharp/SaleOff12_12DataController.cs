using System;
using System.Collections.Generic;

public class SaleOff12_12DataController : NMSingleton<SaleOff12_12DataController>
{
	private const string key = "sale_12_12_";

	private IAPOfferData _offerData;

	private long _timeStart;

	private long _timeEnd;

	private int _seasion;

	public Action<List<ResourceValue>> OnBuyPack;

	public static int max_buy => 0;

	public int level_unlock => 0;

	public IAPOfferData OfferData => null;

	protected override void Init()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void OnPurchase(string obj)
	{
	}

	private void CheckPackType()
	{
	}

	private void Save()
	{
	}

	private void OnChangeScene(SceneState state)
	{
	}

	private void CheckTime()
	{
	}

	public bool IsUnLock()
	{
		return false;
	}

	public bool CanShowPopup()
	{
		return false;
	}

	public bool IsActive()
	{
		return false;
	}

	public bool CanBuy()
	{
		return false;
	}

	public TimeSpan GetTime()
	{
		return default(TimeSpan);
	}

	private int UserType()
	{
		return 0;
	}

	public string GetProductTypes()
	{
		return null;
	}

	public string GetProductTypesFake()
	{
		return null;
	}

	public string GetPrices()
	{
		return null;
	}

	public string GetPricesFake()
	{
		return null;
	}

	public int GetTagSaleOf()
	{
		return 0;
	}

	private int GetIndexInData()
	{
		return 0;
	}

	public List<ResourceValue> GetResourceValuesInPack()
	{
		return null;
	}

	public void Purchase()
	{
	}

	public void UpdateDataFromServer(IAPOfferData data)
	{
	}
}
