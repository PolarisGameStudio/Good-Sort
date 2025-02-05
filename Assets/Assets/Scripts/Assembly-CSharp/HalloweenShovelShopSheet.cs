using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class HalloweenShovelShopSheet
{
	public int id;

	public EncryptedInt amount;

	private static Dictionary<int, HalloweenShovelShopSheet> dictionary;

	public static HalloweenShovelShopSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, HalloweenShovelShopSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, HalloweenShovelShopSheet> dic)
	{
	}
}
