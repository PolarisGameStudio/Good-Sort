using System.Collections.Generic;
using Falcon;

public class SCCountryTeamLeaderboard : SCMessage
{
	public TeamInfoLeaderboard myTeam;

	public List<TeamInfoLeaderboard> teamLeaderboard;

	public int numPage;

	public int page;

	public string countryCode;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
