using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class BundlePurchase_2Sheet
{
	public int bundle;

	public EncryptedInt[] rewardType;

	public EncryptedInt[] rewardValue;

	private static Dictionary<int, BundlePurchase_2Sheet> dictionary;

	public static BundlePurchase_2Sheet Get(int bundle)
	{
		return null;
	}

	public static Dictionary<int, BundlePurchase_2Sheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, BundlePurchase_2Sheet> dic)
	{
	}
}
