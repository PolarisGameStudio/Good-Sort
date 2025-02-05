using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class LunarNewYearBundleSheet
{
	public int id;

	public string name;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	private static Dictionary<int, LunarNewYearBundleSheet> dictionary;

	public static LunarNewYearBundleSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, LunarNewYearBundleSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, LunarNewYearBundleSheet> dic)
	{
	}
}
