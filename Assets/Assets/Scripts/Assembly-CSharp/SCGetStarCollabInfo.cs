using System.Collections.Generic;
using Falcon;

public class SCGetStarCollabInfo : SCMessage
{
	public int state;

	public int milk;

	public List<UserInfoStarCollab> userInfos;

	public int grandReward;

	public long timeInviteTime;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
