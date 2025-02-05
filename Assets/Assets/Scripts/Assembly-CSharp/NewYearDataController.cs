using System;
using System.Collections.Generic;

public class NewYearDataController : NMSingleton<NewYearDataController>
{
	private const string key = "new_year_endless";

	private NewYearData _data;

	private List<int> _indexFreeUser;

	private List<int> _indexPaidUser;

	private int _maxRewardFreeUser;

	private int _maxRewardPaidUser;

	private int _maxRewardByWine;

	private const int NUM_REWARD_LOOP = 5;

	private long _timeStart;

	private long _timeEnd;

	private int _season;

	private List<string> _productsIAP;

	public Action<int> OnClaimByWine;

	private const string Item_Type = "new_year_endless";

	public Action<int> onClaim;

	private int levelUnlock => 0;

	public NewYearData Data => null;

	public int GetNumberRewardByIndex => 0;

	public int GetNumberRewardByWine => 0;

	protected override void Init()
	{
	}

	private void OnChangeScene(SceneState state)
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

	public bool IsUnLock()
	{
		return false;
	}

	public bool IsActive()
	{
		return false;
	}

	public DateTime GetTimeStart()
	{
		return default(DateTime);
	}

	public DateTime GetTimeEnd()
	{
		return default(DateTime);
	}

	private void UpdateTimeFromRemoteConfig()
	{
	}

	private NewYearEndlessRewardByIndexSheet GetCurrentRewardData()
	{
		return null;
	}

	private NewYearEndlessRewardByIndexSheet GetRewardData(int index)
	{
		return null;
	}

	public bool IsFree(int index)
	{
		return false;
	}

	public bool IsMax()
	{
		return false;
	}

	public TimeSpan GetTimeRemaining()
	{
		return default(TimeSpan);
	}

	public bool CanClaimFree()
	{
		return false;
	}

	public List<string> GetProductsIAP()
	{
		return null;
	}

	public bool IsX2Wine()
	{
		return false;
	}

	public bool IsShowPopup()
	{
		return false;
	}

	public string GetPrice(int index)
	{
		return null;
	}

	public List<ResourceValue> GetResourceValuesByIndex(int index)
	{
		return null;
	}

	public void AddWine(int wine)
	{
	}

	public void ClaimRewardByWine(int index)
	{
	}

	public RewardState GetRewardStateByWine(int index)
	{
		return default(RewardState);
	}

	public ResourceValue GetResourceValueByWine(int index)
	{
		return null;
	}

	public int GetNumberWine(int index)
	{
		return 0;
	}

	private int GetIndexByWine(int wine)
	{
		return 0;
	}

	public RewardState GetRewardState(int index)
	{
		return default(RewardState);
	}

	public void Claim(int index)
	{
	}

	public void UpdateDataFromServer(NewYearDataServer dataServer)
	{
	}
}
