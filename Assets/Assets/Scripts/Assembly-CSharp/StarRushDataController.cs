using System;
using System.Collections.Generic;

public class StarRushDataController : NMSingleton<StarRushDataController>, IEvent
{
	public enum UserType
	{
		HardCore = 0,
		Normal = 1,
		Casual = 2,
		Silent = 3
	}

	public enum Power
	{
		Easy = 0,
		Normal = 1,
		Hard = 2,
		VeryHard = 3
	}

	public enum State
	{
		Waiting = 0,
		Playing = 1,
		Ended = 2
	}

	private const string key = "star_rush";

	private const int level_unlock = 15;

	private StarRushData _starRush;

	public Action onStart;

	public Action onReset;

	public StarRushData StarRush => null;

	public List<UserStarRushInfo> GetListUserInfo => null;

	protected override void Init()
	{
	}

	private void AddStar(int amount)
	{
	}

	public bool IsUnlock()
	{
		return false;
	}

	public bool IsWaiting()
	{
		return false;
	}

	public bool IsPlaying()
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

	private void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void Save()
	{
	}

	public TimeSpan GetTimeSpanEnd()
	{
		return default(TimeSpan);
	}

	public bool IsShowTut()
	{
		return false;
	}

	public void ShowTut()
	{
	}

	public void ValidateData()
	{
	}

	public void CheckTime()
	{
	}

	public void CheckEnd()
	{
	}

	private void SortByStar()
	{
	}

	public bool NeedUpdateRank()
	{
		return false;
	}

	public bool NeedUpdateStar()
	{
		return false;
	}

	public void Start()
	{
	}

	public List<ResourceValue> GetResourceValues()
	{
		return null;
	}

	public UserStarRushInfo GetYourSelfInfo()
	{
		return null;
	}

	public bool CanClaimResource()
	{
		return false;
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

	public void UpdatePreData()
	{
	}

	public void ClaimResource()
	{
	}

	public State GetState()
	{
		return default(State);
	}

	public void UpdateDataFromServer(StarRushData starRush)
	{
	}
}
