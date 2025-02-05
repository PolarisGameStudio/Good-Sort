using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class HalloweenPack_FreeSheet
{
	public int id;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	public string price;

	private static Dictionary<int, HalloweenPack_FreeSheet> dictionary;

	public static HalloweenPack_FreeSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, HalloweenPack_FreeSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, HalloweenPack_FreeSheet> dic)
	{
	}
}
