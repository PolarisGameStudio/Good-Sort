using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class EndlessPack_2_NewSheet
{
	public int id;

	public EncryptedInt purchaseType;

	public EncryptedInt[] rewardType;

	public EncryptedInt[] rewardValue;

	public EncryptedInt[] rewardTypeIncludeCollection;

	public EncryptedInt[] rewardValueIncludeCollection;

	public EncryptedInt chestType;

	private static Dictionary<int, EndlessPack_2_NewSheet> dictionary;

	public static EndlessPack_2_NewSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, EndlessPack_2_NewSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, EndlessPack_2_NewSheet> dic)
	{
	}
}
