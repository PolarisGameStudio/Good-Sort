using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class CollectionFullSetRewardSheet
{
	public int id;

	public EncryptedInt resourceType;

	public EncryptedInt resourceValue;

	private static Dictionary<int, CollectionFullSetRewardSheet> dictionary;

	public static CollectionFullSetRewardSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, CollectionFullSetRewardSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, CollectionFullSetRewardSheet> dic)
	{
	}
}
