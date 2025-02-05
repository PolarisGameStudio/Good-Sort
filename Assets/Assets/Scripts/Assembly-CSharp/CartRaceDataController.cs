using System;
using System.Collections.Generic;

public class CartRaceDataController : NMSingleton<CartRaceDataController>, IEvent
{
	private const string key = "cart_race";

	private const int level_unlock = 15;

	private CartRaceData _cartRace;

	public const int NUM_REWARD = 3;

	private const int time_take_place = 24;

	public Action onStart;

	private DateTime _lastTimeCheckUpdateScore;

	public Action onReset;

	public CartRaceData CartRace => null;

	public int LEVEL_WIN => 0;

	protected override void Init()
	{
	}

	private void CompleteLevel()
	{
	}

	private void InitData()
	{
	}

	public void SetDataToDefault()
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

	public void EndSession()
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

	public bool NeedUpdate()
	{
		return false;
	}

	public void ConfirmNeedUpdate()
	{
	}

	public TimeSpan GetTimeSpanEnd()
	{
		return default(TimeSpan);
	}

	public List<CartRaceUserInfo> GetDataUser()
	{
		return null;
	}

	private DateTime GetTimeStart()
	{
		return default(DateTime);
	}

	public List<ResourceValue> GetResourceValues(int top)
	{
		return null;
	}

	public void Start()
	{
	}

	public int GetTimeComplete(int index)
	{
		return 0;
	}

	private List<int> CreateListWithTotal(int total, int n)
	{
		return null;
	}

	private DateTime GetLastTimeUpdateScore()
	{
		return default(DateTime);
	}

	private void SaveLastTimeUpdateScore()
	{
	}

	private void CheckTime()
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

	public bool CanClaim()
	{
		return false;
	}

	public void ClaimResource()
	{
	}

	public (List<int>, List<int>) GetUserRanks()
	{
		return default((List<int>, List<int>));
	}

	public int GetNumUserComplete()
	{
		return 0;
	}

	public CartRaceUserInfo GetYourselfInfo()
	{
		return null;
	}

	public CartRaceState GetCartRaceState()
	{
		return default(CartRaceState);
	}

	private void CheckWin()
	{
	}

	public void UpDateDataFromServer(CartRaceData cartRace)
	{
	}

	public bool IsEndRace()
	{
		return false;
	}

	public bool IsWinLevel()
	{
		return false;
	}

	public void ConfirmWinLevel()
	{
	}

	public bool IsUsedToPlay()
	{
		return false;
	}
}
