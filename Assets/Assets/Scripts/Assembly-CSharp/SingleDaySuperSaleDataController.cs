using System;
using System.Collections.Generic;
using MagicExcel;

public class SingleDaySuperSaleDataController : NMSingleton<SingleDaySuperSaleDataController>
{
	public readonly int num_pack;

	private const string key = "single_day_sale";

	public const int id_frame = -4;

	private SingleDaySuperrSaleData _singleDayData;

	private long _timeStart;

	private long _timeEnd;

	private int _seasion;

	public Action<List<ResourceValue>> OnBuyPack;

	public int level_unlock => 0;

	public static int max_buy => 0;

	public SingleDaySuperrSaleData SingleDayData => null;

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

	public bool IsContainFrame()
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

	public void Purchase(int index)
	{
	}

	public void UpdateDataFromServer(SingleDaySuperrSaleData data)
	{
	}
}
