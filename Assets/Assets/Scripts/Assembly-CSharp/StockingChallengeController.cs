using System;
using System.Collections.Generic;

public class StockingChallengeController : NMSingleton<StockingChallengeController>, IEvent
{
	private const string key = "stocking_n";

	private const int level_unlock = 18;

	private StockingChallengeData _stocking;

	public int s_PointReceived;

	public Action onReset;

	public Action onStart;

	private List<int> _multiplePoint;

	private List<int> targetPoints;

	private const string itemItype = "stocking";

	private const int time_take_place = 24;

	public StockingChallengeData Stocking => null;

	public int NumStreak => 0;

	protected override void Init()
	{
	}

	private void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void Lose()
	{
	}

	public bool NeedUpdateIcon()
	{
		return false;
	}

	public void ConfirmNeedUpdateIcon()
	{
	}

	private void LevelComplete()
	{
	}

	private void Save()
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	public bool IsUnlock()
	{
		return false;
	}

	public bool IsWaiting()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}

	public StockingState GetState()
	{
		return default(StockingState);
	}

	public void EndSession()
	{
	}

	public int GetNumPlay()
	{
		return 0;
	}

	public void ResetWhenEnd()
	{
	}

	public void AddActionReset(Action action)
	{
	}

	public bool CanActive()
	{
		return false;
	}

	public bool IsShowTut()
	{
		return false;
	}

	public void ShowTut()
	{
	}

	public bool IsShowFeature()
	{
		return false;
	}

	public void ShowFeature()
	{
	}

	public void Start()
	{
	}

	public List<StockingUser> GetAllUser_ByPoint()
	{
		return null;
	}

	public List<StockingUser> GetAllUser_ByPrePoint()
	{
		return null;
	}

	public StockingUser GetYourSelf()
	{
		return null;
	}

	public int GetMultipleByWinstreak(int streak)
	{
		return 0;
	}

	public List<int> GetMultiplePoints()
	{
		return null;
	}

	public List<int> GetTargetPoints()
	{
		return null;
	}

	public int GetCurrentIndexRewardByPoint()
	{
		return 0;
	}

	public RewardState GetRewardByPointState(int index)
	{
		return default(RewardState);
	}

	public void ClaimRewardByPoint(int index)
	{
	}

	public void ClaimRewardByRank()
	{
	}

	public List<ResourceValue> GetResourcesByPoint(int index)
	{
		return null;
	}

	public List<ResourceValue> GetResourceByRank(int rank)
	{
		return null;
	}

	public TimeSpan GetTimeEnd()
	{
		return default(TimeSpan);
	}

	private DateTime GetTimeStart()
	{
		return default(DateTime);
	}

	private int GetCurrentRank()
	{
		return 0;
	}

	public void CheckTime()
	{
	}

	public bool NeedUpdate()
	{
		return false;
	}

	public void ConfirmUpdate()
	{
	}

	public void UpdateDataFromServer(StockingChallengeData challengeData)
	{
	}
}
