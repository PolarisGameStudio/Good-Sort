using Falcon;

public class CSSendRequest : CSMessage
{
	public int code;

	public CSSendRequest(int code)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
