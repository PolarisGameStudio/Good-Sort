using Falcon;

public class CSGetTeamBattleInfoByTeam : CSMessage
{
	public int teamCode;

	public int seasonId;

	public CSGetTeamBattleInfoByTeam(int teamCode, int seasonId)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
