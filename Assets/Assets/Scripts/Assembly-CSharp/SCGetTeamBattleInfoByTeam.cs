using Falcon;

public class SCGetTeamBattleInfoByTeam : SCMessage
{
	public TeamBattleInfoDetail info;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
