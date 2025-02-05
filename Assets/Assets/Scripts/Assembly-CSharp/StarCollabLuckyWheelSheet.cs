using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class StarCollabLuckyWheelSheet
{
	public int index;

	public EncryptedFloat chance;

	public EncryptedInt type;

	public EncryptedInt score;

	private static Dictionary<int, StarCollabLuckyWheelSheet> dictionary;

	public static StarCollabLuckyWheelSheet Get(int index)
	{
		return null;
	}

	public static Dictionary<int, StarCollabLuckyWheelSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, StarCollabLuckyWheelSheet> dic)
	{
	}
}
