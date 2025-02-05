using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class ShovelByLevelSheet
{
	public int id;

	public EncryptedInt amount;

	private static Dictionary<int, ShovelByLevelSheet> dictionary;

	public static ShovelByLevelSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, ShovelByLevelSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, ShovelByLevelSheet> dic)
	{
	}
}
