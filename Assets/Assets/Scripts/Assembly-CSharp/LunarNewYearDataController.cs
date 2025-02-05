using System;
using System.Collections.Generic;

public class LunarNewYearDataController : NMSingleton<LunarNewYearDataController>
{
	private const string key = "lunar_stall";

	public const int NUM_DECOR = 12;

	public const int MAX_DECOR_CAN_UNLOCK_IN_SCREEN = 4;

	private LunarNewYearData _lunarNewYearData;

	private int _envelopeFromLevel;

	private bool _canShowPopupWhenWinLevel;

	private LunarNewYearStatePopup _statePopup;

	private const string key_log_first_open = "last_time_open_lunar";

	public Action<int, int> OnUnlockDecor;

	public const string ITEM_TYPE = "lunar_stall";

	public Action OnCheckState;

	private int _state;

	private long _timeEnd;

	private int _id;

	private bool isSetNoti;

	public GetDataByPage<UserInfoScore> leaderboardData;

	public Action<int> onConfirmEnd;

	private int levelUnlock => 0;

	private int levelIntroEvent => 0;

	public LunarNewYearData LunarNewYearData => null;

	protected override void Init()
	{
	}

	private void OnSceneChange(SceneState state)
	{
	}

	private void InitData()
	{
	}

	private void CompleteLevel()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void InitSeasonData(int id)
	{
	}

	public int GetEnvelopeClaimFromLevel()
	{
		return 0;
	}

	public void ResetEnvelopeClaimFromLevel()
	{
	}

	public bool IsUnLock()
	{
		return false;
	}

	public bool CanShowIcon()
	{
		return false;
	}

	public LunarNewYearState GetState()
	{
		return default(LunarNewYearState);
	}

	public TimeSpan GetTimeRemaining()
	{
		return default(TimeSpan);
	}

	public LunarNewYearStatePopup GetStatePopup()
	{
		return default(LunarNewYearStatePopup);
	}

	public bool CanShowPopup()
	{
		return false;
	}

	private DateTime LastTimeLogOpenPopupEvent()
	{
		return default(DateTime);
	}

	public void ShowPopup()
	{
	}

	public bool IsShowTut()
	{
		return false;
	}

	public void ConfirmShowTut()
	{
	}

	public void JoinEvent()
	{
	}

	public int GetCurrentLevelReward()
	{
		return 0;
	}

	public bool IsPassAllLevel()
	{
		return false;
	}

	public List<ResourceValue> GetGrandLevelReward()
	{
		return null;
	}

	public int GetFrameId()
	{
		return 0;
	}

	public bool CanDecorSomething()
	{
		return false;
	}

	public List<int> GetListIndexCanUnlock()
	{
		return null;
	}

	private void Save()
	{
	}

	public void AddEnvelope(int envelope)
	{
	}

	public void BuyIAPEnvelope(int index)
	{
	}

	public bool CanBuyIAPEnvelope(int index)
	{
		return false;
	}

	public bool CanBuyPack()
	{
		return false;
	}

	public void BuyPack()
	{
	}

	public bool IsX2Envelope()
	{
		return false;
	}

	public DateTime GetTimeStartX2Envelope()
	{
		return default(DateTime);
	}

	public DateTime GetTimeEndX2Envelope()
	{
		return default(DateTime);
	}

	public TimeSpan GetTimeRemainingX2Envelope()
	{
		return default(TimeSpan);
	}

	public bool CanUnLockDecor(int decorIndex, int itemIndex)
	{
		return false;
	}

	public int GetEnvelopeRequire(int decorIndex, int itemIndex)
	{
		return 0;
	}

	public void UnLockDecor(int decorIndex, int itemIndex)
	{
	}

	private void DecreaseEventEnvelope(int envelope, string itemType, string itemId)
	{
	}

	private int GetNumDecorUnlocked()
	{
		return 0;
	}

	public bool CanUseDecor(int decorIndex, int itemIndex)
	{
		return false;
	}

	public void UseCustomDecor(int decorIndex, int itemIndex)
	{
	}

	public (ChestType?, List<ResourceValue>) GetResourceValuesInProgress(int index)
	{
		return default((ChestType?, List<ResourceValue>));
	}

	public RewardState GetRewardState(int index)
	{
		return default(RewardState);
	}

	public void ClaimRewardProgress(int index)
	{
	}

	public void CheckState()
	{
	}

	public void CheckStateFromServer(SCCheckLunarNewYear sc)
	{
	}

	private void SetNoti()
	{
	}

	private int GetLeaderboardRewardType(int rank)
	{
		return 0;
	}

	public ResourceValue GetResourceLeaderboardByRank(int rank)
	{
		return null;
	}

	public void GetLeaderboardFromServer(SCGetLeaderboardLunarNewYear sc)
	{
	}

	public void ConFirmEnd()
	{
	}

	public void ComfirmEndFromServer(SCConfirmEndLunarNewYear sc)
	{
	}

	public void UpdateDataFromServer(LunarNewYearDataServer lunarNewYear)
	{
	}
}
