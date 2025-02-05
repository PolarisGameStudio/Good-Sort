using System;
using System.Collections.Generic;

[Serializable]
public class CollectionSetStarSheet
{
	public int id;

	public int[] star;

	private static Dictionary<int, CollectionSetStarSheet> dictionary;

	public static CollectionSetStarSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, CollectionSetStarSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, CollectionSetStarSheet> dic)
	{
	}
}
