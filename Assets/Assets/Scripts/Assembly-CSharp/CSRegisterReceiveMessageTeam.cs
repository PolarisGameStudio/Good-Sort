using Falcon;

public class CSRegisterReceiveMessageTeam : CSMessage
{
	public bool register;

	public CSRegisterReceiveMessageTeam(bool register)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
