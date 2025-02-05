using Falcon;
using Falcon.PuzzleCore.UserData;

public class ScBindDataUpdate : SCMessage
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
