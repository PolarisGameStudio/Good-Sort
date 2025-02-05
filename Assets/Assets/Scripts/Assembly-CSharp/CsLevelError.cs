using Falcon;

public class CsLevelError : CSMessage
{
	public int last_version;

	public int level;

	public CsLevelError(int level)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
