using Falcon;

public class CSAddScoreTeamTreasure : CSMessage
{
	public int score;

	public CSAddScoreTeamTreasure(int score)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
