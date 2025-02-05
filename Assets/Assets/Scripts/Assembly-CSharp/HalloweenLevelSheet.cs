using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class HalloweenLevelSheet
{
	public int level;

	public EncryptedInt[] rewardTypes;

	public EncryptedInt[] rewardValues;

	public EncryptedInt[] rewardTypesIncludeCollection;

	public EncryptedInt[] rewardValuesIncludeCollection;

	public EncryptedInt chest;

	public EncryptedInt shovelRequire;

	public EncryptedInt[] itemRequires;

	private static Dictionary<int, HalloweenLevelSheet> dictionary;

	public static HalloweenLevelSheet Get(int level)
	{
		return null;
	}

	public static Dictionary<int, HalloweenLevelSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, HalloweenLevelSheet> dic)
	{
	}
}
