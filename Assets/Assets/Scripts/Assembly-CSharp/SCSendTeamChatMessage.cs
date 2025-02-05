using Falcon;

public class SCSendTeamChatMessage : SCMessage
{
	public MessageTeam message;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
