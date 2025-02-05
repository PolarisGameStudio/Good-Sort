using Falcon;
using Falcon.PuzzleCore.UserData;

public class CsUpdateData : CSMessage
{
	public ClientData clientData;

	public CsUpdateData(ClientData clientData)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
