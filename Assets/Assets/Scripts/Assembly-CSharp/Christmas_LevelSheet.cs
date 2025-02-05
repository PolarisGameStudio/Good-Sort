using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class Christmas_LevelSheet
{
	public int level;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	public EncryptedInt chest;

	public EncryptedInt[] givenItems;

	public EncryptedInt giftHiddenRequires;

	private static Dictionary<int, Christmas_LevelSheet> dictionary;

	public static Christmas_LevelSheet Get(int level)
	{
		return null;
	}

	public static Dictionary<int, Christmas_LevelSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, Christmas_LevelSheet> dic)
	{
	}
}
