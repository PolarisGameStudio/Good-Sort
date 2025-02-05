using System;
using System.Collections.Generic;

[Serializable]
public class FailSafeSheet
{
	public int id;

	public int level;

	public int[] failToActives;

	private static Dictionary<int, FailSafeSheet> dictionary;

	public static FailSafeSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, FailSafeSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, FailSafeSheet> dic)
	{
	}
}
