using System.Collections.Generic;
using Falcon;

public class SCGetLeaderboardContest : SCMessage
{
	public List<UserInfoLeaderboard> userLeaderboard;

	public UserInfoLeaderboard myRank;

	public bool reset;

	public long timeEnd;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
