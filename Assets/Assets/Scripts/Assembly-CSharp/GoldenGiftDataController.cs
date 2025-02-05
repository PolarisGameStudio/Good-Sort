using System;

public class GoldenGiftDataController : NMSingleton<GoldenGiftDataController>
{
	private const string key = "golden_gift";

	private int _numReward;

	private GoldenGiftData _goldenGiftData;

	public int NumReward => 0;

	public GoldenGiftData GoldenGiftData => null;

	private int num_day_reset => 0;

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

	private void CheckTime()
	{
	}

	public bool IsShowGodenGiftLock()
	{
		return false;
	}

	public int GetLevelUnlock()
	{
		return 0;
	}

	public bool IsActiveIcon()
	{
		return false;
	}

	public bool IsActive()
	{
		return false;
	}

	public ResourceValue GetResource(int index)
	{
		return null;
	}

	public int GetPoint(int index)
	{
		return 0;
	}

	public bool IsTut()
	{
		return false;
	}

	public bool IsMax()
	{
		return false;
	}

	public TimeSpan GetTimeReset()
	{
		return default(TimeSpan);
	}

	public int GetIndexReward(int point)
	{
		return 0;
	}

	public void AddGoldenGift(int amount)
	{
	}

	public void CheckAndStartTimer()
	{
	}

	public bool CanClaim()
	{
		return false;
	}

	public void Claim()
	{
	}

	public void UpdatePreValue()
	{
	}

	public void UpdateDataFromServer(GoldenGiftDataServer goldenGift)
	{
	}
}
