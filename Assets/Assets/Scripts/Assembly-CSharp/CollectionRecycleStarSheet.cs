using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class CollectionRecycleStarSheet
{
	public int id;

	public EncryptedInt star;

	public EncryptedInt[] rewardType;

	public EncryptedInt[] rewardValue;

	private static Dictionary<int, CollectionRecycleStarSheet> dictionary;

	public static CollectionRecycleStarSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, CollectionRecycleStarSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, CollectionRecycleStarSheet> dic)
	{
	}
}
