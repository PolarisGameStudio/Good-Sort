using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class EndlessPack_1_NewSheet
{
	public int id;

	public EncryptedInt purchaseType;

	public EncryptedInt[] rewardType;

	public EncryptedInt[] rewardValue;

	public EncryptedInt[] rewardTypeIncludeCollection;

	public EncryptedInt[] rewardValueIncludeCollection;

	public EncryptedInt chestType;

	private static Dictionary<int, EndlessPack_1_NewSheet> dictionary;

	public static EndlessPack_1_NewSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, EndlessPack_1_NewSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, EndlessPack_1_NewSheet> dic)
	{
	}
}
