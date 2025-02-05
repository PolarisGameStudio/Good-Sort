using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class CartRaceRewardSheet
{
	public int top;

	public EncryptedInt[] type;

	public EncryptedInt[] amount;

	public EncryptedInt[] typeIncludeCollection;

	public EncryptedInt[] amountIncludeCollection;

	private static Dictionary<int, CartRaceRewardSheet> dictionary;

	public static CartRaceRewardSheet Get(int top)
	{
		return null;
	}

	public static Dictionary<int, CartRaceRewardSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, CartRaceRewardSheet> dic)
	{
	}
}
