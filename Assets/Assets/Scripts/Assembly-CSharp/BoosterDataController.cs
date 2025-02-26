using System;
using System.Collections.Generic;

public class BoosterDataController : NMSingleton<BoosterDataController>
{
	public class SelectBooster
	{
		public BoosterKind kind;

		public bool isFree;
	}

	private const string key = "booster";


	public static Action<int> onUseBooster;

	private List<SelectBooster> _boosterSelected;

	private const int num_item_for_tut = 1;

	private BoosterKind? boosterTut;


	public static Dictionary<BoosterKind, AdRewardType> DicBoosterAdsType;

	public static readonly Dictionary<BoosterKind, string> DicBoosterNameToLog;

	private int numBoosterInit => 0;

	public List<SelectBooster> BoosterSelected => null;

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

	private void Save()
	{
	}

	public bool HaveBooster(BoosterKind boosterKind)
	{
		return false;
	}

	public bool HaveBoosterFree(BoosterKind boosterKind)
	{
		return false;
	}

	public void AddInfiTime(BoosterKind booster, int minute)
	{
	}

	public void AddBooster(BoosterKind booster, int num)
	{
	}

	public void AddBoosterFree(BoosterKind booster, int num)
	{
	}

	protected void MinusBooster(BoosterKind booster, int num, string where)
	{
	}

	protected void MinusBoosterFree(BoosterKind booster, int num)
	{
	}

	public void UseBooster(BoosterKind boosterKind, int num, string where)
	{
	}

	public void UseBoosterFree(BoosterKind booster, int num)
	{
	}

	public void UpdateDataFromServer(BoosterDataServer booster)
	{
	}

	public bool IsInfi(BoosterKind kind)
	{
		return false;
	}

	public TimeSpan GetTimeSpanInfi(BoosterKind kind)
	{
		return default(TimeSpan);
	}

	public int GetNumBooster(BoosterKind kind)
	{
		return 0;
	}

	public int GetNumBoosterFree(BoosterKind kind)
	{
		return 0;
	}

	public bool IsUse(BoosterKind kind)
	{
		return false;
	}

	public bool CanUser(BoosterKind kind)
	{
		return false;
	}

	public void Use(BoosterKind kind)
	{
	}

	public void UseBoosterTut(BoosterKind kind)
	{
	}

	public void UnUse(BoosterKind kind)
	{
	}

	public bool IsShowBooster()
	{
		return false;
	}

	public bool ShowButtonWatchAds()
	{
		return false;
	}

	public void WatchAdsToPlay(Action action)
	{
	}

	public BoosterKind? GetTutBooster()
	{
		return null;
	}

	public int GetLevelUnLockBooster(BoosterKind kind)
	{
		return 0;
	}

	public bool IsUnLockBooster(BoosterKind kind)
	{
		return false;
	}

	public void AddItemForTut(BoosterKind kind)
	{
	}

	public bool IsTut(BoosterKind kind)
	{
		return false;
	}

	public void ActiveBoosterTut()
	{
	}

	public bool CanBuyBooster()
	{
		return false;
	}

	public void BuyBooster(BoosterKind kind)
	{
	}

	public void WatchAdsToGetBooster(BoosterKind kind, Action onComplete)
	{
	}
}
