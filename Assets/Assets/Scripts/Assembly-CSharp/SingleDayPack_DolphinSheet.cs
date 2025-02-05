using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class SingleDayPack_DolphinSheet
{
	public int id;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	private static Dictionary<int, SingleDayPack_DolphinSheet> dictionary;

	public static SingleDayPack_DolphinSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, SingleDayPack_DolphinSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, SingleDayPack_DolphinSheet> dic)
	{
	}
}
