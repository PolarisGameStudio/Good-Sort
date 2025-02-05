using System;
using System.Collections.Generic;

public class LimitedPackController : NMSingleton<LimitedPackController>
{
	private const string key = "limit_pack";

	private string _pack;

	public Action onBuyComplete;

	public string Pack => null;

	protected override void Init()
	{
	}

	private void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void Save()
	{
	}

	public List<ResourceValue> GetResources()
	{
		return null;
	}

	public string GetPrice()
	{
		return null;
	}

	public bool CanBuy()
	{
		return false;
	}

	public void Buy()
	{
	}

}
