using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class PiggyBankSheet
{
	public int id;

	public EncryptedInt ltv;

	public EncryptedInt saleOffRatio;

	public EncryptedInt goldMin;

	public EncryptedInt goldMax;

	public EncryptedInt goldPerLevel;

	private static Dictionary<int, PiggyBankSheet> dictionary;

	public static PiggyBankSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, PiggyBankSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, PiggyBankSheet> dic)
	{
	}
}
