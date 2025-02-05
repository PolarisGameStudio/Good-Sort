using System.Collections.Generic;

public class ChestEndGameController : NMSingleton<ChestEndGameController>
{
	public const int NUM_LEVEL_TO_CLAIM_CHEST = 5;

	public const int LEVEL_TO_SHOW = 1;

	private List<ResourceValue> resources;

	private List<int> levelClaimed;

	private const string Item_Type = "chest_end_game";

	protected override void Init()
	{
	}

	private void OnChangeScene(SceneState state)
	{
	}

	public float GetProgressRatio()
	{
		return 0f;
	}

	public (int, int) GetValueProgress()
	{
		return default((int, int));
	}

	public bool IsShow()
	{
		return false;
	}

	public bool CanClaim()
	{
		return false;
	}

	public List<ResourceValue> GetResources()
	{
		return null;
	}

	public void Claim()
	{
	}

	public void WatchAdToClaim()
	{
	}
}
