using System.Collections.Generic;
using Falcon;

public class SCGetLeaderboardGlobalEventPVP : SCMessage
{
	public List<UserInfoEventPVP> userLeaderboard;

	public UserInfoEventPVP myRank;

	public int pageNum;

	public int page;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
