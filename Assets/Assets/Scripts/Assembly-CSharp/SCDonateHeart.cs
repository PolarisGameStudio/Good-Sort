using Falcon;

public class SCDonateHeart : SCMessage
{
	public int status;

	public MessageTeam message;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
