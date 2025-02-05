using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class Sale_12_12Sheet
{
	public int id;

	public string name;

	public EncryptedInt saleOff;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	private static Dictionary<int, Sale_12_12Sheet> dictionary;

	public static Sale_12_12Sheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, Sale_12_12Sheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, Sale_12_12Sheet> dic)
	{
	}
}
