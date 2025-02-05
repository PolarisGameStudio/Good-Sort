using Falcon;

public class CSAddScoreTeamBattle : CSMessage
{
	public int score;

	public int seasonId;

	public CSAddScoreTeamBattle(int score, int seasonId)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
