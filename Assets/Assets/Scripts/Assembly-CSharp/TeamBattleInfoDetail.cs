using System;
using System.Collections.Generic;

[Serializable]
public class TeamBattleInfoDetail : TeamInfoSimple
{
	public int score;

	public int rank;

	public List<UserInfoTeamBattle> userInfos;
}
