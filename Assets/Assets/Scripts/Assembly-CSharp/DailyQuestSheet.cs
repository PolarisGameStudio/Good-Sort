using System;
using System.Collections.Generic;
using MagicExcel;

[Serializable]
public class DailyQuestSheet
{
	public int id;

	public string questDes;

	public EncryptedInt target;

	public string rewardName;

	public EncryptedInt rewardType;

	public EncryptedInt rewardValue;

	private static Dictionary<int, DailyQuestSheet> dictionary;

	public static DailyQuestSheet Get(int id)
	{
		return null;
	}

	public static Dictionary<int, DailyQuestSheet> GetDictionary()
	{
		return null;
	}

	public static void SetDictionary(Dictionary<int, DailyQuestSheet> dic)
	{
	}
}
