using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class BlackFriday_WhalesSheet
{
	public int id;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	private static Dictionary<int, BlackFriday_WhalesSheet> dictionary;

	public static BlackFriday_WhalesSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, BlackFriday_WhalesSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, BlackFriday_WhalesSheet> dic)
	{
	}
}
