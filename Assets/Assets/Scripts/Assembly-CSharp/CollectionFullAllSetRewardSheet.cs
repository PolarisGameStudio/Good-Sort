using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class CollectionFullAllSetRewardSheet
{
	public int id;

	public EncryptedInt[] resourceType;

	public EncryptedInt[] resourceValue;

	private static Dictionary<int, CollectionFullAllSetRewardSheet> dictionary;

	public static CollectionFullAllSetRewardSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, CollectionFullAllSetRewardSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, CollectionFullAllSetRewardSheet> dic)
	{
	}
}
