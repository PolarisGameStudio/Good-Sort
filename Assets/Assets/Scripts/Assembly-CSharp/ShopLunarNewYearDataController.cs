using System;
using System.Collections.Generic;

public class ShopLunarNewYearDataController : NMSingleton<ShopLunarNewYearDataController>
{
	public Action<int> OnBuyEnvelope;

	public Action OnBuyPack;

	protected override void Init()
	{
	}

	private string[] GetEnvelopeProduct()
	{
		return null;
	}

	public string GetPriceEnvelope(int index)
	{
		return null;
	}

	public int GetEnvelopAmout(int index)
	{
		return 0;
	}

	public bool CanBuyEnvelope()
	{
		return false;
	}

	public bool CanBuyEnvelope(int index)
	{
		return false;
	}

	public void BuyEnvelope(int index)
	{
	}

	public bool CanBuyPack()
	{
		return false;
	}

	private int GetPackIndex()
	{
		return 0;
	}

	public string GetPackProduct()
	{
		return null;
	}

	public List<ResourceValue> GetResourcesPack()
	{
		return null;
	}

	public string GetPrice()
	{
		return null;
	}

	public void BuyPack()
	{
	}
}
