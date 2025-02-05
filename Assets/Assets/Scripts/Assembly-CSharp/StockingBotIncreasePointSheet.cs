using System;
using System.Collections.Generic;

[Serializable]
public class StockingBotIncreasePointSheet
{
	public int rank;

	public int min;

	public int max;

	private static Dictionary<int, StockingBotIncreasePointSheet> dictionary;

	public static StockingBotIncreasePointSheet Get(int rank)
	{
		return null;
	}

	public static Dictionary<int, StockingBotIncreasePointSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, StockingBotIncreasePointSheet> dic)
	{
	}
}
