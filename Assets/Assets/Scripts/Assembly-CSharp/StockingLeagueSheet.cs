using System;
using System.Collections.Generic;

[Serializable]
public class StockingLeagueSheet
{
	public int id;

	public string des;

	public int numRank1;

	public int numRank2;

	public int numRank3;

	public int numRank4;

	private static Dictionary<int, StockingLeagueSheet> dictionary;

	public static StockingLeagueSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, StockingLeagueSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, StockingLeagueSheet> dic)
	{
	}
}
