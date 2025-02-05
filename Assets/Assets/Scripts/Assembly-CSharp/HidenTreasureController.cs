using System;
using System.Collections.Generic;

public class HidenTreasureController : NMSingleton<HidenTreasureController>, IEvent
{
	private const string key = "hiden_treasure";

	private const int level_unlock = 18;

	private int max_player_in_ui;

	private int num_player_to_show_exact_ui;

	public const int total_player_participate = 100;

	public const int num_level_to_complete = 7;

	private HidenTreasure _hidenTreasure;

	public Action onReset;

	public Action onStart;

	public const int totol_gold_reward = 10000;

	public Action onEnd;

	public HidenTreasure HidenTreasure => null;

	protected override void Init()
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

	private DateTime GetTimeEnd()
	{
		return default(DateTime);
	}

	public TimeSpan GetTimeSpanEnd()
	{
		return default(TimeSpan);
	}

	public void CheckTime()
	{
	}

	public bool CanActive()
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

	public bool IsUnlock()
	{
		return false;
	}

	public bool IsShowFeature()
	{
		return false;
	}

	public bool IsShowTut()
	{
		return false;
	}

	public void ShowFeature()
	{
	}

	public void ShowTut()
	{
	}

	public bool IsWaiting()
	{
		return false;
	}

	public bool IsPlaying()
	{
		return false;
	}

	public bool IsTimeOut()
	{
		return false;
	}

	public void Start()
	{
	}

	private void Lose()
	{
	}

	private void CompleteLevel()
	{
	}

	public int GetPlayerRemain(int level)
	{
		return 0;
	}

	public List<UserHidenTreasure> GetUsers()
	{
		return null;
	}

	public void UpdateNumPlayer()
	{
	}

	public bool IsChange()
	{
		return false;
	}

	public bool IsChangeLevel()
	{
		return false;
	}

	private UserHidenTreasure GetUserHiden(int avatar, bool drop)
	{
		return null;
	}

	public bool CanClaim()
	{
		return false;
	}

	public void Claim()
	{
	}

	public int GetGoldClaim()
	{
		return 0;
	}

	public void End()
	{
	}

	public void UpdateDataFromServer(HidenTreasure hidenTreasure)
	{
	}
}
