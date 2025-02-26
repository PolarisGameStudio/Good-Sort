using System;

[Serializable]
public class DailyQuest
{
	public int id;


	public int state;

	public DailyQuest()
	{
	}

	public DailyQuest(DailyQuestServer dailyQuest)
	{
	}

	public RewardState GetRewardState()
	{
		return default(RewardState);
	}

	public DailyQuest(int id)
	{
	}
}
