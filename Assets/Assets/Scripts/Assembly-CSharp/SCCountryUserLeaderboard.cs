using System.Collections.Generic;
using Falcon;

public class SCCountryUserLeaderboard : SCMessage
{
	public UserInfoLeaderboard myRank;

	public List<UserInfoLeaderboard> userLeaderboard;

	public int numPage;

	public int page;

	public string countryCode;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
