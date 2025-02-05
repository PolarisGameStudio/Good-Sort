using Falcon;

public class CSTeamJoinReq : CSMessage
{
	public int team_code;

	public CSTeamJoinReq(int team_code)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
