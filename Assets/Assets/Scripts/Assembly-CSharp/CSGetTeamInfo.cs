using Falcon;

public class CSGetTeamInfo : CSMessage
{
	public int code;

	public CSGetTeamInfo(int code)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
