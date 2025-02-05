using System;
using System.Collections.Generic;

[Serializable]
public class HalloweenItemSheet
{
	public int id;

	public int width;

	public int height;

	private static Dictionary<int, HalloweenItemSheet> dictionary;

	public static HalloweenItemSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, HalloweenItemSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, HalloweenItemSheet> dic)
	{
	}
}
