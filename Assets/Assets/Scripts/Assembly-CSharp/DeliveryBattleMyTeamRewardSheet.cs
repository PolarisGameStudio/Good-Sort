using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class DeliveryBattleMyTeamRewardSheet
{
	public int top;

	public EncryptedInt rewardType;

	public EncryptedInt rewardValue;

	private static Dictionary<int, DeliveryBattleMyTeamRewardSheet> dictionary;

	public static DeliveryBattleMyTeamRewardSheet Get(int top)
	{
		return null;
	}

	public static Dictionary<int, DeliveryBattleMyTeamRewardSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, DeliveryBattleMyTeamRewardSheet> dic)
	{
	}
}
