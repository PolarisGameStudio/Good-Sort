using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class HalloweenPack_MinowSheet
{
	public int id;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	private static Dictionary<int, HalloweenPack_MinowSheet> dictionary;

	public static HalloweenPack_MinowSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, HalloweenPack_MinowSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, HalloweenPack_MinowSheet> dic)
	{
	}
}
