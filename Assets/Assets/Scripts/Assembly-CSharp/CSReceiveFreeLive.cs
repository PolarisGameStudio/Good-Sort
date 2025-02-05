using Falcon;

public class CSReceiveFreeLive : CSMessage
{
	public int player_code;

	public CSReceiveFreeLive(int player_code)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
