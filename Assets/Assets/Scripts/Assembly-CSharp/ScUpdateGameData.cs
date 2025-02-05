using Falcon;

public class ScUpdateGameData : SCMessage
{
	public int sequence;

	public GameInfo gameData;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
