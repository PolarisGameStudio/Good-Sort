using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class TeamTreasureRewardByTopPlayeSheet
{
	public int id;

	public EncryptedInt rewardType;

	public EncryptedInt rewardValue;

	private static Dictionary<int, TeamTreasureRewardByTopPlayeSheet> dictionary;

	public static TeamTreasureRewardByTopPlayeSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, TeamTreasureRewardByTopPlayeSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, TeamTreasureRewardByTopPlayeSheet> dic)
	{
	}
}
