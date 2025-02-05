using System;
using System.Collections.Generic;

[Serializable]
public class StockingChallengeData
{
	public int numUpdate;

	public int showTut;

	public int state;

	public long timeEnd;

	public int preWintreak;

	public int winStreak;

	public List<int> rewardsByPoint;

	public List<StockingUser> userInfos;

	public void Update(StockingChallengeData stocking)
	{
	}
}
