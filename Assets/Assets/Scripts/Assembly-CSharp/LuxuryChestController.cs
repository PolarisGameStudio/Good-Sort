using System;
using System.Collections.Generic;

public class LuxuryChestController : NMSingleton<LuxuryChestController>
{
	private const string key = "lux_chest";

	private LuxuryChestData _chest;

	public Action OnUpdateStar;

	private List<LuxuryResource> _luxuryResources;

	private const string ItemType = "lux_chest";

	public LuxuryChestData Chest => null;

	private int CurrentStar => 0;

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

	public bool NeedUpdateStar()
	{
		return false;
	}

	public void UpdateStar()
	{
	}

	public bool CanClaimChest()
	{
		return false;
	}

	private (int, int, int) GetRewardData(int star)
	{
		return default((int, int, int));
	}

	private int GetStarTarget(int currentStar)
	{
		return 0;
	}

	private int GetTotalStar(int index)
	{
		return 0;
	}

	public int GetTargetStar(int index)
	{
		return 0;
	}

	public List<LuxuryResource> GetLuxuryResources()
	{
		return null;
	}

	private (int, int) GetStarProgress()
	{
		return default((int, int));
	}

	public (int, int) GetCurrentStarProgress()
	{
		return default((int, int));
	}

	public void Claim(int index)
	{
	}

	public void WatchAdsToClaimX2(int index, Action action)
	{
	}

	public List<ResourceValue> GetResources(int index)
	{
		return null;
	}

	public void UpdateDataFromServer(LuxuryChestServer luxuryChest)
	{
	}
}
