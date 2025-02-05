using System;
using System.Collections.Generic;

public class ChristmasDataController : NMSingleton<ChristmasDataController>
{
	private const string key = "christmas_event";

	private const int gold_convert_per_gifthidden = 20;

	private const string ItemType = "christmas";

	public static int max_index_level_reward;

	private ChristmasData _christmasData;

	private bool _isScheduleNoti;

	private int c_giftHiddenClaimFromLevel;

	private long _timeShowIcon;

	private long _timeStart;

	private long _timeEnd;

	private const string key_log_first_open = "last_time_open_christmas";

	private int level_unlock => 0;

	public ChristmasData ChristmasData => null;

	protected override void Init()
	{
	}

	private void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void OnChangeScene(SceneState sceneState)
	{
	}

	public void ScheduleNoti()
	{
	}

	private void OnCompleteLevel()
	{
	}

	public int GetGiftHiddenClaimFromLevel()
	{
		return 0;
	}

	public void ResetGiftHiddenClaimFromLevel()
	{
	}

	public void BuyPack()
	{
	}

	private DateTime GetTimeShowIcon()
	{
		return default(DateTime);
	}

	public DateTime GetTimeStart()
	{
		return default(DateTime);
	}

	public DateTime GetTimeEnd()
	{
		return default(DateTime);
	}

	public DateTime GetTimeX2Gift()
	{
		return default(DateTime);
	}

	public TimeSpan GetTimeRemaining()
	{
		return default(TimeSpan);
	}

	private void UpdateTimeFromRemoteConfig()
	{
	}

	public void AddGiftHidden(int amount)
	{
	}

	public ChristmasState GetState()
	{
		return default(ChristmasState);
	}

	public bool IsShowTut()
	{
		return false;
	}

	public void DoneTut()
	{
	}

	public bool IsUnLock()
	{
		return false;
	}

	public bool CanRecieveGiftFromLevel()
	{
		return false;
	}

	public bool IsActiving()
	{
		return false;
	}

	public bool IsShowIcon()
	{
		return false;
	}

	public bool IsX2GiftHiddenResource()
	{
		return false;
	}

	public List<RewardState> GetListRewardStates()
	{
		return null;
	}

	public RewardState GetRewardState(int level)
	{
		return default(RewardState);
	}

	public void ClaimReward(int index)
	{
	}

	public (ChestType?, List<ResourceValue>) GetLevelReward(int level)
	{
		return default((ChestType?, List<ResourceValue>));
	}

	public List<ResourceValue> GetGrandLevelReward()
	{
		return null;
	}

	public int GetFrameId()
	{
		return 0;
	}

	public void ClaimFrame()
	{
	}

	public bool IsLayerFullyFilled()
	{
		return false;
	}

	private List<int> GetCurrentLayer()
	{
		return null;
	}

	private bool CanPutUp()
	{
		return false;
	}

	public int PutUp(int itemIndex)
	{
		return 0;
	}

	public int PutDown(int itemIndex)
	{
		return 0;
	}

	public int GetSlotOfItem(int itemIndex)
	{
		return 0;
	}

	public List<int> GetListRemainingItems()
	{
		return null;
	}

	public List<int> GetListItemsCanInteractive()
	{
		return null;
	}

	private List<int> GetListGivenItems()
	{
		return null;
	}

	private DateTime LastTimeLogOpenPopupEvent()
	{
		return default(DateTime);
	}

	public void OpenPopupEvent()
	{
	}

	public void NextLevel()
	{
	}

	public void ConfirmFinish()
	{
	}

	public bool IsWarningLoseGiftHidden()
	{
		return false;
	}

	public void ConvertRemainingGiftHidden()
	{
	}

	public int GetNumCellOfLevel(int level)
	{
		return 0;
	}

	private int GetNumRequiredSinkOfLevel(int level)
	{
		return 0;
	}

	public bool IsPassAllLevel()
	{
		return false;
	}

	private void ResetCurrentLayerAfterTry(ChristmasData.TryData tryData)
	{
	}

	public bool IsAttemptedBefore(List<int> userTry)
	{
		return false;
	}

	public ChristmasData.TryData GetResultOfTry(List<int> userTry)
	{
		return null;
	}

	private void HandleGetTryData(ChristmasData.TryData trydata)
	{
	}

	public bool CheckIfAllGuessesCorrect(ChristmasData.TryData tryData)
	{
		return false;
	}

	private List<int> GetCorrectSlots()
	{
		return null;
	}

	private ChristmasData.TryData GetResultOfTry(List<int> userTry, List<int> hiddenPermutation)
	{
		return null;
	}

	private List<(List<int>, int)> GenerateAllPossiblePermutations(List<int> userTry)
	{
		return null;
	}

	private int GetNumTrue(List<int> userTry, List<int> hiddenPermutation)
	{
		return 0;
	}

	private List<ChristmasData.TryData> GetFailSaved()
	{
		return null;
	}

	private Dictionary<int, HashSet<int>> GetPossibleValuesForEachSlot(List<int> correctSlots)
	{
		return null;
	}

	private List<int> GetListItemNotTrue()
	{
		return null;
	}

	public void ValidateData()
	{
	}

	public void UpdateDataFromServer(ChristmasDataServer dataServer)
	{
	}

	public void Save()
	{
	}
}
