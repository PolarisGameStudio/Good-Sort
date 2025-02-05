using System;

[Serializable]
public class DailyQuestServer
{
	public int id;

	public int progress;

	public int state;

	public DailyQuestServer()
	{
	}

	public DailyQuestServer(DailyQuest dailyQuest)
	{
	}

	public RewardState GetRewardState()
	{
		return default(RewardState);
	}
}
