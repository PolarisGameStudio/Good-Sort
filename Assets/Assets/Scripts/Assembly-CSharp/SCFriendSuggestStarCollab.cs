using System.Collections.Generic;
using Falcon;

public class SCFriendSuggestStarCollab : SCMessage
{
	public List<UserSimpleInfo> pendings;

	public List<UserSimpleInfo> friends;

	public List<UserSimpleInfo> suggestions;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
