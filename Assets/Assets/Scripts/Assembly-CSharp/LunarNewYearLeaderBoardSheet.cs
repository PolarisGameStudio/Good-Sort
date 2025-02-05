using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class LunarNewYearLeaderBoardSheet
{
	public int id;

	public EncryptedInt gold;

	private static Dictionary<int, LunarNewYearLeaderBoardSheet> dictionary;

	public static LunarNewYearLeaderBoardSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, LunarNewYearLeaderBoardSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, LunarNewYearLeaderBoardSheet> dic)
	{
	}
}
