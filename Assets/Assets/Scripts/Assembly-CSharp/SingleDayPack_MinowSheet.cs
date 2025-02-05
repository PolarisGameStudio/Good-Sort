using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class SingleDayPack_MinowSheet
{
	public int id;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	private static Dictionary<int, SingleDayPack_MinowSheet> dictionary;

	public static SingleDayPack_MinowSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, SingleDayPack_MinowSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, SingleDayPack_MinowSheet> dic)
	{
	}
}
