using System;
using System.Collections.Generic;
using Falcon;

public class SCGetOnlyFriendInfos : SCMessage
{
	public List<UserSimpleInfoWithTeam> friends;

	public static Action<List<UserSimpleInfoWithTeam>> onGetFriends;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
