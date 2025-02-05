using Falcon;
using Falcon.PuzzleCore.Team;

public class SCCheckTeamState : SCMessage
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
