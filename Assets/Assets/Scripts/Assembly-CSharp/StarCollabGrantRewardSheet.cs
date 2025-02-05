using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class StarCollabGrantRewardSheet
{
	public int index;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	private static Dictionary<int, StarCollabGrantRewardSheet> dictionary;

	public static StarCollabGrantRewardSheet Get(int index)
	{
		return null;
	}

	public static Dictionary<int, StarCollabGrantRewardSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, StarCollabGrantRewardSheet> dic)
	{
	}
}
