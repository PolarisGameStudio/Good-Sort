using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class ShovelInDailyQuestSheet
{
	public int id;

	public string des;

	public EncryptedInt amount;

	private static Dictionary<int, ShovelInDailyQuestSheet> dictionary;

	public static ShovelInDailyQuestSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, ShovelInDailyQuestSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, ShovelInDailyQuestSheet> dic)
	{
	}
}
