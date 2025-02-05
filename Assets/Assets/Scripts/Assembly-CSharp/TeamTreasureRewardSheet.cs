using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class TeamTreasureRewardSheet
{
	public int id;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	private static Dictionary<int, TeamTreasureRewardSheet> dictionary;

	public static TeamTreasureRewardSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, TeamTreasureRewardSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, TeamTreasureRewardSheet> dic)
	{
	}
}
