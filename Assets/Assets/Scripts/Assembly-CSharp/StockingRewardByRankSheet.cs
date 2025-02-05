using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class StockingRewardByRankSheet
{
	public int id;

	public string des;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] typeIncludeCollection;

	public EncryptedInt[] amountIncludeCollection;

	private static Dictionary<int, StockingRewardByRankSheet> dictionary;

	public static StockingRewardByRankSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, StockingRewardByRankSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, StockingRewardByRankSheet> dic)
	{
	}
}
