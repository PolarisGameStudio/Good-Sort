using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class StarCollabProgressSheet
{
	public int index;

	public EncryptedInt score;

	public EncryptedInt[] rewardType;

	public EncryptedInt[] rewardValue;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValueIncludeCollection;

	private static Dictionary<int, StarCollabProgressSheet> dictionary;

	public static StarCollabProgressSheet Get(int index)
	{
		return null;
	}

	public static Dictionary<int, StarCollabProgressSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, StarCollabProgressSheet> dic)
	{
	}
}
