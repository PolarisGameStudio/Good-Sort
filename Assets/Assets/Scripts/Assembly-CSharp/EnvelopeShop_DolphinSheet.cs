using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class EnvelopeShop_DolphinSheet
{
	public int id;

	public EncryptedInt amount;

	public string price;

	private static Dictionary<int, EnvelopeShop_DolphinSheet> dictionary;

	public static EnvelopeShop_DolphinSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, EnvelopeShop_DolphinSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, EnvelopeShop_DolphinSheet> dic)
	{
	}
}
