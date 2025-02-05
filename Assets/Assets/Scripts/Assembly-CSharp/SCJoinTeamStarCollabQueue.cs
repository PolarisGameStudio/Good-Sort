using Falcon;

public class SCJoinTeamStarCollabQueue : SCMessage
{
	public int status;

	public MessageTeam message;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
