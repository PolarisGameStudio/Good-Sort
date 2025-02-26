using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UserResourceController : NMSingleton<UserResourceController>
{


	private string key;

	private UserResource _userResource;

	public Action onUpdateResource;

	public static int DefaultHeart;

	private const int NUM_SECOND_TO_INCREASE_HEART = 1800;

	private int _lastHeartAddedByTime;

	private DateTime _targetTime;

	private Coroutine _couroutineUpdateHeart;

	private WaitForSeconds waitForSeconds;


	public static Action<int> onAddGold;

	public static Action<int> onAddStar;

	public static Action<int> onMinusGold;

	public List<FreeLiveRowData> freeLives;

	public Action onGetFreeLive;

	public Action onReceiveMaxFreeLive;

	public Action onReceiveFreeLive;

	public UserResource UserResource => null;

	private int goldInit => 0;

	public int NumSecondToInCreaseHeart => 0;

	public TimeSpan TimeSpanUpdateHeart => default(TimeSpan);

	public int NumHeartRestorePerLoop => 0;

	protected override void Init()
	{
	}

	public void CheckingDataFromRemoteConfig()
	{
	}

	private void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	public void QuitLevel()
	{
	}

	public void UnQuitLevel()
	{
	}

	public bool IsInfiHeart()
	{
		return false;
	}

	public DateTime GetTargetTimeInfiHeart()
	{
		return default(DateTime);
	}

	public TimeSpan GetTargetTimeSpanInfiHearth()
	{
		return default(TimeSpan);
	}

	public void AddInfiHeart(int minute)
	{
	}

	public bool CanPlayLevel()
	{
		return false;
	}

	public int GetMaxHeart()
	{
		return 0;
	}

	private void CheckAndUpdateHeart()
	{
	}

	private IEnumerator CoroutineUpdateHeart()
	{
		return null;
	}

	private void UpdateCurrencyWithOutCheckTime()
	{
	}

	public bool CanBuyHeart()
	{
		return false;
	}

	public void BuyHeart()
	{
	}

	public bool IsMaxHeart()
	{
		return false;
	}

	public void WatchAds_FreeHearth(Action onComplete)
	{
	}

	private void Save()
	{
	}

	private void UpdateResource()
	{
	}

	public void SetMaxHeart()
	{
	}

	public void SetHeart(int amount)
	{
	}

	public void SetGold(int amount)
	{
	}

	public void SetStar(int amount)
	{
	}

	public void AddHeart(int amount)
	{
	}

	public void AddGold(int amount)
	{
	}

	public void AddStar(int amount)
	{
	}

	public void MinusHeart(int amount)
	{
	}

	public void MinusGold(int amount, string itemType, string itemId)
	{
	}

	public void MinusStar(int amount)
	{
	}

	public bool CanMinusHeart(int amount)
	{
		return false;
	}

	public bool CanMinusGold(int amount)
	{
		return false;
	}

	public bool CanMinusStar(int amount)
	{
		return false;
	}

	public void AddInfiTime(int minute)
	{
	}

	public bool IsX2Reward()
	{
		return false;
	}

	public TimeSpan GetTimeX2Reward()
	{
		return default(TimeSpan);
	}

	public void GetFreeLive()
	{
	}

	public void GetFreeLiveFromServer(List<FreeLiveRowData> datas)
	{
	}

	public void ReceiveFreeLive(int code)
	{
	}

	public int GetMaxLiveCanReceive()
	{
		return 0;
	}

	public void ReceiveMaxLive()
	{
	}

	public void ReceiveMaxLiveFromServer(int status, List<FreeLiveRowData> data, int num)
	{
	}

	public void ReceiveFreeLiveFromSerer(int status, int playerCode)
	{
	}

	public void UpdateDataFromServer(UserResourceServer userResource)
	{
	}
}
