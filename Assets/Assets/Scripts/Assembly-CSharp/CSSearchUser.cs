using Falcon;

public class CSSearchUser : CSMessage
{
	public string search;

	public CSSearchUser(string search)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
