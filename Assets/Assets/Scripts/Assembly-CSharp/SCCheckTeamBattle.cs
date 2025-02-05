using Falcon;

public class SCCheckTeamBattle : SCMessage
{
	public int state;

	public long timeEnd;

	public int myRank;

	public int myRankIndividual;

	public int userScore;

	public int teamState;

	public int seasonId;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
