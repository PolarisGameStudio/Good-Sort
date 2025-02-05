using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class SingleDayPack_FreeSheet
{
	public int id;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	private static Dictionary<int, SingleDayPack_FreeSheet> dictionary;

	public static SingleDayPack_FreeSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, SingleDayPack_FreeSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, SingleDayPack_FreeSheet> dic)
	{
	}
}
