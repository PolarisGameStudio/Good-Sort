using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class BundlePurchase_1Sheet
{
	public int bundle;

	public EncryptedInt[] rewardType;

	public EncryptedInt[] rewardValue;

	private static Dictionary<int, BundlePurchase_1Sheet> dictionary;

	public static BundlePurchase_1Sheet Get(int bundle)
	{
		return null;
	}

	public static Dictionary<int, BundlePurchase_1Sheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, BundlePurchase_1Sheet> dic)
	{
	}
}
