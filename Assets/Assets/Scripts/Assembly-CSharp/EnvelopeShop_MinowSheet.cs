using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class EnvelopeShop_MinowSheet
{
	public int id;

	public EncryptedInt amount;

	public string price;

	private static Dictionary<int, EnvelopeShop_MinowSheet> dictionary;

	public static EnvelopeShop_MinowSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, EnvelopeShop_MinowSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, EnvelopeShop_MinowSheet> dic)
	{
	}
}
