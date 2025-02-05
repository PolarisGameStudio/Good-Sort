using System;
using CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public class DailyQuest
{
	public int id;

	public ObscuredInt progress;

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
