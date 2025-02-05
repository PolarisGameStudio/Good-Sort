public class CSSendCardCollection : CSMessageWaitLoginSuccess
{
	public SendCard data;

	public int code;

	public CSSendCardCollection(SendCard data, int code)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
