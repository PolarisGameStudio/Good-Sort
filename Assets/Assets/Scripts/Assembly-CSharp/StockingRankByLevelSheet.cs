using System;
using System.Collections.Generic;

[Serializable]
public class StockingRankByLevelSheet
{
	public int rank;

	public int level;

	private static Dictionary<int, StockingRankByLevelSheet> dictionary;

	public static StockingRankByLevelSheet Get(int rank)
	{
		return null;
	}

	public static Dictionary<int, StockingRankByLevelSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, StockingRankByLevelSheet> dic)
	{
	}
}
