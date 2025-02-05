using System.Collections.Generic;
using Falcon;

public class SCGetLeaderboardLunarNewYear : SCMessage
{
	public List<UserInfoScore> userInfos;

	public UserInfoScore myInfo;

	public int totalPage;

	public int page;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
