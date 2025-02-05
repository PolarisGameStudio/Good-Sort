using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class LunarNewYearDecorSheet
{
	public int id;

	public string name;

	public EncryptedInt envelopeRequires;

	private static Dictionary<int, LunarNewYearDecorSheet> dictionary;

	public static LunarNewYearDecorSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, LunarNewYearDecorSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, LunarNewYearDecorSheet> dic)
	{
	}
}
