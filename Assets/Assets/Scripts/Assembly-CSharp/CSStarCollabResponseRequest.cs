using Falcon;

public class CSStarCollabResponseRequest : CSMessage
{
	public int code;

	public int accept;

	public CSStarCollabResponseRequest(int code, int accept)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
