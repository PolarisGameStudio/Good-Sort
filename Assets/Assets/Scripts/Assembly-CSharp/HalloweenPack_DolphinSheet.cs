using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class HalloweenPack_DolphinSheet
{
	public int id;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	private static Dictionary<int, HalloweenPack_DolphinSheet> dictionary;

	public static HalloweenPack_DolphinSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, HalloweenPack_DolphinSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, HalloweenPack_DolphinSheet> dic)
	{
	}
}
