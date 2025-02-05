using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class LunarNewYearRewardProgressSheet
{
	public int id;

	public EncryptedInt chestType;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	private static Dictionary<int, LunarNewYearRewardProgressSheet> dictionary;

	public static LunarNewYearRewardProgressSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, LunarNewYearRewardProgressSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, LunarNewYearRewardProgressSheet> dic)
	{
	}
}
