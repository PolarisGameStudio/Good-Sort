using Falcon;
using Falcon.PuzzleCore.UserData;

public class ScUpdateAllData : SCMessage
{
	public ClientData clientData;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
