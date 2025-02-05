using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class DeliveryBattleRewardSheet
{
	public int top;

	public EncryptedInt rewardType;

	public EncryptedInt rewardValue;

	private static Dictionary<int, DeliveryBattleRewardSheet> dictionary;

	public static DeliveryBattleRewardSheet Get(int top)
	{
		return null;
	}

	public static Dictionary<int, DeliveryBattleRewardSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, DeliveryBattleRewardSheet> dic)
	{
	}
}
