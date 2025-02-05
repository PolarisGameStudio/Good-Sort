using Falcon;

public class SCConfirmEndTeamBattle : SCMessage
{
	public int state;

	public int rankTeam;

	public int rankIndividual;

	public int score;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
