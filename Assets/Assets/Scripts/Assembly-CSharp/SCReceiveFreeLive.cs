using Falcon;

public class SCReceiveFreeLive : SCMessage
{
	public int status;

	public int player_code;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
