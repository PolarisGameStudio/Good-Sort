using System.Collections.Generic;
using Falcon;

public class SCMasterUserLeaderboard : SCMessage
{
	public List<LeaderboardMasterUser> userInfos;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
