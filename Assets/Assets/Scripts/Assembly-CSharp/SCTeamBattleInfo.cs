using System.Collections.Generic;
using Falcon;

public class SCTeamBattleInfo : SCMessage
{
	public List<TeamBattleInfo> teamInfos;

	public TeamBattleInfo myTeam;

	public long timeEnd;

	public int state;

	public int seasonId;

	public TeamBattleInfoDetail myTeamDetail;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
