using System;
using System.Collections.Generic;

[Serializable]
public class StockingLeagueRatioSheet
{
	public int rank;

	public float[] ratio;

	private static Dictionary<int, StockingLeagueRatioSheet> dictionary;

	public static StockingLeagueRatioSheet Get(int rank)
	{
		return null;
	}

	public static Dictionary<int, StockingLeagueRatioSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, StockingLeagueRatioSheet> dic)
	{
	}
}
