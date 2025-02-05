using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class GoldGiftSheet
{
	public int id;

	public EncryptedInt point;

	public EncryptedInt type;

	public EncryptedInt amount;

	public EncryptedInt typeIncludeCollection;

	public EncryptedInt amountIncludeCollection;

	private static Dictionary<int, GoldGiftSheet> dictionary;

	public static GoldGiftSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, GoldGiftSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, GoldGiftSheet> dic)
	{
	}
}
