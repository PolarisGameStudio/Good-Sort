using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class NewYearEndlessRewardByWineSheet
{
	public int id;

	public EncryptedInt wine;

	public EncryptedInt rewardTypes;

	public EncryptedInt rewardValues;

	public EncryptedInt rewardTypesIncludeCollection;

	public EncryptedInt rewardValuesIncludeCollection;

	private static Dictionary<int, NewYearEndlessRewardByWineSheet> dictionary;

	public static NewYearEndlessRewardByWineSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, NewYearEndlessRewardByWineSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, NewYearEndlessRewardByWineSheet> dic)
	{
	}
}
