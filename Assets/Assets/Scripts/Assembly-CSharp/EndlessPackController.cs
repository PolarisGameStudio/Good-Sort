using System;
using System.Collections.Generic;

public class EndlessPackController : NMSingleton<EndlessPackController>
{
	public const string key = "end_less_pack";

	private EndlessData _endless;

	public int numReward;

	public Action<int> onClaim;

	private const string Item_Type = "end_less_pack";

	public EndlessData Endless => null;

	protected override void Init()
	{
	}

	private void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	public void Reset()
	{
	}

	public TimeSpan GetTimeSpan()
	{
		return default(TimeSpan);
	}

	private void Save()
	{
	}

	public bool IsShowIntro()
	{
		return false;
	}

	public void ShowIntro()
	{
	}

	public bool CanClaimFree()
	{
		return false;
	}

	public (bool, List<ResourceValue>) CheckTime()
	{
		return default((bool, List<ResourceValue>));
	}

	public void ClaimFreeEndSeasion()
	{
	}

	private List<ResourceValue> GetResourceCanClaimFree()
	{
		return null;
	}

	public bool IsActive()
	{
		return false;
	}

	public bool IsUnLock()
	{
		return false;
	}

	public bool IsMax()
	{
		return false;
	}

	public (ChestType?, List<ResourceValue>) GetResources(int index)
	{
		return default((ChestType?, List<ResourceValue>));
	}

	public bool IsFree(int index)
	{
		return false;
	}

	public int GetLastIndexReward()
	{
		return 0;
	}

	public string GetProductPurchase(int index)
	{
		return null;
	}

	public string GetPrice(int index)
	{
		return null;
	}

	public RewardState GetRewardState(int index)
	{
		return default(RewardState);
	}

	public void Claim(int index)
	{
	}

	private int GetMaxIndexCanClaim()
	{
		return 0;
	}

	public void UpdateDataFromServer(EndlessDataServer endlessData)
	{
	}
}
