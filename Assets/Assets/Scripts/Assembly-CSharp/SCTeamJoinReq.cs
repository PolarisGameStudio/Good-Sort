using Falcon;

public class SCTeamJoinReq : SCMessage
{
	public int status;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
