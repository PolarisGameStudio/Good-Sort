using System.Collections.Generic;
using Falcon;

public class SCCheckTeamTreasure : SCMessage
{
	public int state;

	public long timeEnd;

	public List<int> rewardStates;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
