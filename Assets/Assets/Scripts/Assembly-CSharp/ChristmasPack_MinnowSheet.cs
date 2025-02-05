using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class ChristmasPack_MinnowSheet
{
	public int id;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	public string price;

	private static Dictionary<int, ChristmasPack_MinnowSheet> dictionary;

	public static ChristmasPack_MinnowSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, ChristmasPack_MinnowSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, ChristmasPack_MinnowSheet> dic)
	{
	}
}
