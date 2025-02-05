using Falcon;

public class ScLogin : SCMessage
{
	public int login_status;

	public int update_status;

	public string error_message;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
