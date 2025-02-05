using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class HalloweenPack_WhalesSheet
{
	public int id;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	private static Dictionary<int, HalloweenPack_WhalesSheet> dictionary;

	public static HalloweenPack_WhalesSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, HalloweenPack_WhalesSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, HalloweenPack_WhalesSheet> dic)
	{
	}
}
