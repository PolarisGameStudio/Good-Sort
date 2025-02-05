using System.Collections.Generic;
using Falcon;

public class SCGetFriendInfos : SCMessage
{
	public List<UserSimpleInfoWithTeam> friends;

	public List<UserSimpleInfoWithTeam> friendPending;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
