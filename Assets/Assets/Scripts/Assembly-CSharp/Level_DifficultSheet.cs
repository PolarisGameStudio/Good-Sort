using System;
using System.Collections.Generic;

[Serializable]
public class Level_DifficultSheet
{
	public int level;

	public int diff;

	private static Dictionary<int, Level_DifficultSheet> dictionary;

	public static Level_DifficultSheet Get(int level)
	{
		return null;
	}

	public static Dictionary<int, Level_DifficultSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, Level_DifficultSheet> dic)
	{
	}
}
