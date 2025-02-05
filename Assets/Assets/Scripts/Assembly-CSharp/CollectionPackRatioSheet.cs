using System;
using System.Collections.Generic;

[Serializable]
public class CollectionPackRatioSheet
{
	public int id;

	public string name;

	public int numCard;

	public float[] ratios;

	public int numCardNew;

	private static Dictionary<int, CollectionPackRatioSheet> dictionary;

	public static CollectionPackRatioSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, CollectionPackRatioSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, CollectionPackRatioSheet> dic)
	{
	}
}
