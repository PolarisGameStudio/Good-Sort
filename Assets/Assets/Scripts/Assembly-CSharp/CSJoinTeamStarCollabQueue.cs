using Falcon;

public class CSJoinTeamStarCollabQueue : CSMessage
{
	public long messageId;

	public CSJoinTeamStarCollabQueue(long messageId)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
