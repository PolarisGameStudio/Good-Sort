using Falcon;

public class CSDonateHeart : CSMessage
{
	public long messageId;

	public CSDonateHeart(long messageId)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
