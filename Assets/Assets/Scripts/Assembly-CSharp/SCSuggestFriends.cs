using System.Collections.Generic;
using Falcon;

public class SCSuggestFriends : SCMessage
{
	public List<UserSimpleInfoWithTeam> friends;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
