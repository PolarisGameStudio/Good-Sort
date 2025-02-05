using System.Collections.Generic;
using Falcon;

public class SCGlobalTeamLeaderboard : SCMessage
{
	public List<TeamInfoLeaderboard> userLeaderboard;

	public TeamInfoLeaderboard myRank;

	public int numPage;

	public int page;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
