using System.Collections.Generic;
using Falcon;

public class SCGetTeamJoinRequest : SCMessage
{
	public List<MessageTeam> messages;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
