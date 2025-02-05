using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class SingleDayPack_WhaleSheet
{
	public int id;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	private static Dictionary<int, SingleDayPack_WhaleSheet> dictionary;

	public static SingleDayPack_WhaleSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, SingleDayPack_WhaleSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, SingleDayPack_WhaleSheet> dic)
	{
	}
}
