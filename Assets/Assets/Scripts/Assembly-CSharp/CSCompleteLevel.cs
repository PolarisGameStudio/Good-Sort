using Falcon;

public class CSCompleteLevel : CSMessage
{
	public int diff;

	public CSCompleteLevel(int diff)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
