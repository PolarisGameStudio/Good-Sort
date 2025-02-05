using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class ChristmasPack_DolphinSheet
{
	public int id;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	public string price;

	private static Dictionary<int, ChristmasPack_DolphinSheet> dictionary;

	public static ChristmasPack_DolphinSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, ChristmasPack_DolphinSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, ChristmasPack_DolphinSheet> dic)
	{
	}
}
