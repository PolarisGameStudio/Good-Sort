using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class BlackFriday_MinowSheet
{
	public int id;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	private static Dictionary<int, BlackFriday_MinowSheet> dictionary;

	public static BlackFriday_MinowSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, BlackFriday_MinowSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, BlackFriday_MinowSheet> dic)
	{
	}
}
