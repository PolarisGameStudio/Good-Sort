using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class StockingRewardByPointSheet
{
	public int id;

	public EncryptedInt point;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	private static Dictionary<int, StockingRewardByPointSheet> dictionary;

	public static StockingRewardByPointSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, StockingRewardByPointSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, StockingRewardByPointSheet> dic)
	{
	}
}
