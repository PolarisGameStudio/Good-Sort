using System.Collections.Generic;
using Falcon;

public class SCGetTeamTreasureInfo : SCMessage
{
	public int state;

	public List<UserInfoTeamTreasure> userInfos;

	public int totalScore;

	public List<int> targetScores;

	public List<int> rewardStates;

	public TeamInfoSimple teamInfo;

	public bool canClaimRewardByRank;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
