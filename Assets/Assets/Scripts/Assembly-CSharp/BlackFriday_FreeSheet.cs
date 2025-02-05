using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class BlackFriday_FreeSheet
{
	public int id;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	private static Dictionary<int, BlackFriday_FreeSheet> dictionary;

	public static BlackFriday_FreeSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, BlackFriday_FreeSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, BlackFriday_FreeSheet> dic)
	{
	}
}
