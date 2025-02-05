using System;
using System.Collections.Generic;

[Serializable]
public class DailyQuestDataServer
{
	public long time;

	public List<DailyQuestServer> quests;

	public int chestState;

	public void Update(DailyQuestData dailyQuest)
	{
	}
}
