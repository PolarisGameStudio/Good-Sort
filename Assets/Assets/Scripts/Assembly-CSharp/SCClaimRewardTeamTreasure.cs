using System.Collections.Generic;
using Falcon;

public class SCClaimRewardTeamTreasure : SCMessage
{
	public int status;

	public List<int> rewardStates;

	public int index;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
