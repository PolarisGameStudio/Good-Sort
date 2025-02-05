using Falcon;
using Falcon.PuzzleCore.Team;

public class SCEditTeamInfo : SCMessage
{
	public int message;

	public TeamInfo teamInfo;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
