using Falcon;
using Falcon.PuzzleCore.Team;

public class SCGetTeamInfo : SCMessage
{
	public TeamInfo teamInfo;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
