using System.Collections.Generic;
using Falcon;

public class SCGetTeamChat : SCMessage
{
	public int page;

	public int totalPage;

	public List<MessageTeam> messages;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
