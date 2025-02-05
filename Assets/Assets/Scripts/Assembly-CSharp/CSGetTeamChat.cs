using Falcon;

public class CSGetTeamChat : CSMessage
{
	public int page;

	public CSGetTeamChat(int page)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
