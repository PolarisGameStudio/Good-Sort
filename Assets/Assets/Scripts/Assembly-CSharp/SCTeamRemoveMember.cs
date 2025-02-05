using Falcon;
using Falcon.PuzzleCore.Team;

public class SCTeamRemoveMember : SCMessage
{
	public int status;

	public TeamInfo teamInfo;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
