using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class EnvelopeShop_WhalesSheet
{
	public int id;

	public EncryptedInt amount;

	public string price;

	private static Dictionary<int, EnvelopeShop_WhalesSheet> dictionary;

	public static EnvelopeShop_WhalesSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, EnvelopeShop_WhalesSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, EnvelopeShop_WhalesSheet> dic)
	{
	}
}
