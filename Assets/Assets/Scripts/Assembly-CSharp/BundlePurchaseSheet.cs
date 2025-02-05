using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class BundlePurchaseSheet
{
	public int bundle;

	public EncryptedInt gold;

	public EncryptedInt powerup;

	public EncryptedInt booster;

	public EncryptedInt live;

	private static Dictionary<int, BundlePurchaseSheet> dictionary;

	public static BundlePurchaseSheet Get(int bundle)
	{
		return null;
	}

	public static Dictionary<int, BundlePurchaseSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, BundlePurchaseSheet> dic)
	{
	}
}
