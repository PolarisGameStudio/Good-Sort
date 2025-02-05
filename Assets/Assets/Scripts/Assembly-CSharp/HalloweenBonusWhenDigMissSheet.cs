using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class HalloweenBonusWhenDigMissSheet
{
	public int id;

	public EncryptedInt ratio;

	public EncryptedInt rewardType;

	public EncryptedInt rewardValue;

	private static Dictionary<int, HalloweenBonusWhenDigMissSheet> dictionary;

	public static HalloweenBonusWhenDigMissSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, HalloweenBonusWhenDigMissSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, HalloweenBonusWhenDigMissSheet> dic)
	{
	}
}
