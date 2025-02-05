using System;
using System.Collections.Generic;
using MagicExcel;

public class BlackFridayDataController : NMSingleton<BlackFridayDataController>
{
	public readonly int num_pack;

	private const string key = "black_friday";

	private BlackFridayData _blackFridayData;

	private long _timeStart;

	private long _timeEnd;

	private int _seasion;

	public Action<List<ResourceValue>> OnBuyPack;

	public int level_unlock => 0;

	public static int max_buy => 0;

	public BlackFridayData BlackFriday => null;

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

	public bool CanBuySomething()
	{
		return false;
	}

	public TimeSpan GetTime()
	{
		return default(TimeSpan);
	}

	public bool CanBuy(int index)
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

	public string[] GetProductTypesFake()
	{
		return null;
	}

	public string[] GetPricesFake()
	{
		return null;
	}

	public int[] GetTagSaleOf()
	{
		return null;
	}

	private List<ResourceValue> GetResourceValuesInPack(EncryptedInt[] rewardTypes, EncryptedInt[] rewardValues)
	{
		return null;
	}

	public List<ResourceValue> GetResourceValuesInPack(int index)
	{
		return null;
	}

	public string GetPopupName()
	{
		return null;
	}

	public void Purchase(int index)
	{
	}

	public void UpdateDataFromServer(BlackFridayData data)
	{
	}
}
