using System;
using System.Collections.Generic;

[Serializable]
public class DailyQuestData
{
	public long time;

	public List<DailyQuest> quests;

	public int chestState;

	public void Update(DailyQuestDataServer dailyQuest)
	{
	}

	public DailyQuest GetQuest(int id)
	{
		return null;
	}

	public bool ContainQuest(int id)
	{
		return false;
	}
}
