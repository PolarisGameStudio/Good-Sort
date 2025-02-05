using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class LuckyWheelSheet
{
	public int index;

	public EncryptedFloat chance;

	public EncryptedInt rewardType;

	public EncryptedInt rewardValue;

	public EncryptedInt shovel;

	public EncryptedInt giftHidden;

	public EncryptedInt envelope;

	private static Dictionary<int, LuckyWheelSheet> dictionary;

	public static LuckyWheelSheet Get(int index)
	{
		return null;
	}

	public static Dictionary<int, LuckyWheelSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, LuckyWheelSheet> dic)
	{
	}
}
