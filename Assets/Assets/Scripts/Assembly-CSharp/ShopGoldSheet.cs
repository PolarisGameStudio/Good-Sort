using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class ShopGoldSheet
{
	public int id;

	public EncryptedInt gold;

	private static Dictionary<int, ShopGoldSheet> dictionary;

	public static ShopGoldSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, ShopGoldSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, ShopGoldSheet> dic)
	{
	}
}
