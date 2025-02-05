using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class MasterPassSheet
{
	public int id;

	public EncryptedInt key;

	public EncryptedInt[] rewardFreeType;

	public EncryptedInt[] rewardFreeValue;

	public EncryptedInt[] typeFreeIncludeCollection;

	public EncryptedInt[] amountFreeIncludeCollection;

	public EncryptedInt chestFreeType;

	public EncryptedInt[] rewardPaidType;

	public EncryptedInt[] rewardPaidValue;

	public EncryptedInt[] typePaidIncludeCollection;

	public EncryptedInt[] amountPaidIncludeCollection;

	public EncryptedInt chestPaidType;

	private static Dictionary<int, MasterPassSheet> dictionary;

	public static MasterPassSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, MasterPassSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, MasterPassSheet> dic)
	{
	}
}
