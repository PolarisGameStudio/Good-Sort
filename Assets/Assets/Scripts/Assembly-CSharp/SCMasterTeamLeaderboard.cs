using System.Collections.Generic;
using Falcon;

public class SCMasterTeamLeaderboard : SCMessage
{
	public List<LeaderboardMasterTeam> teamInfos;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
