using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class StarRushRewardSheet
{
	public int top;

	public EncryptedInt[] type;

	public EncryptedInt[] amount;

	public EncryptedInt[] typeIncludeCollection;

	public EncryptedInt[] amountIncludeCollection;

	private static Dictionary<int, StarRushRewardSheet> dictionary;

	public static StarRushRewardSheet Get(int top)
	{
		return null;
	}

	public static Dictionary<int, StarRushRewardSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, StarRushRewardSheet> dic)
	{
	}
}
