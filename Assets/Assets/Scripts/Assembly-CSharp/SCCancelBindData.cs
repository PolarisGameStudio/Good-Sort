using Falcon;

public class SCCancelBindData : SCMessage
{
	public int status;

	public string message;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
