using System.Collections.Generic;
using Falcon;

public class SCGlobalUserLeaderboard : SCMessage
{
	public List<UserInfoLeaderboard> userLeaderboard;

	public UserInfoLeaderboard myRank;

	public int numPage;

	public int page;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
