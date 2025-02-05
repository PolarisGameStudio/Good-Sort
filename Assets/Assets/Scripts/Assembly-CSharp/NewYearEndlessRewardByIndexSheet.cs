using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class NewYearEndlessRewardByIndexSheet
{
	public int id;

	public EncryptedInt type;

	public EncryptedInt purchaseType;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	private static Dictionary<int, NewYearEndlessRewardByIndexSheet> dictionary;

	public static NewYearEndlessRewardByIndexSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, NewYearEndlessRewardByIndexSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, NewYearEndlessRewardByIndexSheet> dic)
	{
	}
}
