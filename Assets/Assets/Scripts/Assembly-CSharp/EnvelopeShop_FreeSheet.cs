using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class EnvelopeShop_FreeSheet
{
	public int id;

	public EncryptedInt amount;

	public string price;

	private static Dictionary<int, EnvelopeShop_FreeSheet> dictionary;

	public static EnvelopeShop_FreeSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, EnvelopeShop_FreeSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, EnvelopeShop_FreeSheet> dic)
	{
	}
}
