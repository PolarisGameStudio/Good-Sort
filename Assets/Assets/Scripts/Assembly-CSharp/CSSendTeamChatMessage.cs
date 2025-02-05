using Falcon;

public class CSSendTeamChatMessage : CSMessage
{
	public int type;

	public string content;

	public CSSendTeamChatMessage(int type, string content)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
