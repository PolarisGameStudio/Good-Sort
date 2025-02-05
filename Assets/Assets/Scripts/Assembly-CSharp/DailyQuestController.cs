using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

public class DailyQuestController : NMSingleton<DailyQuestController>
{
	private const string key = "daily_quest";

	private static readonly List<int> _questGold;

	private static readonly List<int> _questItem;

	public const int num_quest_per_day = 4;

	private DailyQuestData _questData;

	public Action onCompleteQuest;

	public static Action onGetRewardChest;

	public Action<List<ResourceValue>> onClaimQuest;

	public static readonly ObscuredInt gold_in_chest;

	private List<ResourceValue> c_dataReward;

	public Action onClaimChest;

	private const string Item_Type = "daily_quest";

	public DailyQuestData QuestData => null;

	public int GetNumShovelWhenClaimQuest()
	{
		return 0;
	}

	public int GetNumShovelWhenClaimChest()
	{
		return 0;
	}

	public int GetNumGiftHiddenWhenClaimQuest()
	{
		return 0;
	}

	public int GetNumGiftHiddenWhenClaimChest()
	{
		return 0;
	}

	public int GetNumEnvelopWhenClaimQuest()
	{
		return 0;
	}

	public int GetNumEnvelopWhenClaimChest()
	{
		return 0;
	}

	public int GetLevelToUnLock()
	{
		return 0;
	}

	public bool IsShowDailyQuestLock()
	{
		return false;
	}

	public bool IsShow()
	{
		return false;
	}

	protected override void Init()
	{
	}

	private void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void CheckTime()
	{
	}

	private void Save()
	{
	}

	private void Sort()
	{
	}

	private void InitActionUpdateDailyQuest()
	{
	}

	public string GetDes(int index)
	{
		return null;
	}

	public float GetProgress(int index)
	{
		return 0f;
	}

	public float GetProgressById(int questId)
	{
		return 0f;
	}

	public (int, int) GetProgressValue(int index)
	{
		return default((int, int));
	}

	public ResourceValue GetResource(int index)
	{
		return null;
	}

	public void Claim(int index)
	{
	}

	public float GetChestRatio()
	{
		return 0f;
	}

	public (int, int) GetProgressChestValue()
	{
		return default((int, int));
	}

	private int GetNumQuestClaimed()
	{
		return 0;
	}

	public bool CanClaim()
	{
		return false;
	}

	public bool CanClaimChest()
	{
		return false;
	}

	public bool IsClaimChest()
	{
		return false;
	}

	public List<ResourceValue> GetResourceChest()
	{
		return null;
	}

	public List<ResourceValue> GetResourceChestWhenWatchAds()
	{
		return null;
	}

	public void ClaimChest()
	{
	}

	public void WatchAdToClaimChest()
	{
	}

	public void UpdateDataFromServer(DailyQuestDataServer dailyQuest)
	{
	}

	public TimeSpan GetTimeExprice()
	{
		return default(TimeSpan);
	}
}
