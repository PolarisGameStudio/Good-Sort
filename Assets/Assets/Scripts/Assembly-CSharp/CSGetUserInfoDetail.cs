using Falcon;

public class CSGetUserInfoDetail : CSMessage
{
	public int code;

	public CSGetUserInfoDetail(int code)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
