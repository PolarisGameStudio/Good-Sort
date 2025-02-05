using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class EndlessPackSheet
{
	public int id;

	public EncryptedInt purchaseType;

	public EncryptedInt[] rewardType;

	public EncryptedInt[] rewardValue;

	public EncryptedInt chestType;

	private static Dictionary<int, EndlessPackSheet> dictionary;

	public static EndlessPackSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, EndlessPackSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, EndlessPackSheet> dic)
	{
	}
}
