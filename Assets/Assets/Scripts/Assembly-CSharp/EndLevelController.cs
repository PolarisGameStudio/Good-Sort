using System;

public class EndLevelController : NMSingleton<EndLevelController>
{
	public int curGold;

	public int curStar;

	public Action<int> onWatchAdsComplete;

	protected override void Init()
	{
	}

	public void OnWinLevel(int star)
	{
	}

	public void WatchAdsToClaimGold(float bonusXReward)
	{
	}

	public bool IsShowEndgame()
	{
		return false;
	}
}
