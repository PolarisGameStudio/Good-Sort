using System;
using System.Collections.Generic;

[Serializable]
public class Fake_NamesSheet
{
	public int id;

	public string country;

	public string[] names;

	private static Dictionary<int, Fake_NamesSheet> dictionary;

	public static Fake_NamesSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, Fake_NamesSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, Fake_NamesSheet> dic)
	{
	}
}
