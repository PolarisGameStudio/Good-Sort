using System;
using System.Collections.Generic;

[Serializable]
public class ComboSheet
{
	public int combo;

	public float time;

	public float timeBuff;

	public int star;

	private static Dictionary<int, ComboSheet> dictionary;

	public static ComboSheet Get(int combo)
	{
		return null;
	}

	public static Dictionary<int, ComboSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, ComboSheet> dic)
	{
	}
}
