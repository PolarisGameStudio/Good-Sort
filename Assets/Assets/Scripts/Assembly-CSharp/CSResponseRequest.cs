using Falcon;

public class CSResponseRequest : CSMessage
{
	public int code;

	public int accept;

	public CSResponseRequest(int code, int accept)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
