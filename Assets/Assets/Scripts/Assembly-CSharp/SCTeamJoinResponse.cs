using Falcon;
using Falcon.PuzzleCore.Team;

public class SCTeamJoinResponse : SCMessage
{
	public int status;

	public MessageTeam message;

	public TeamInfo teamInfo;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
