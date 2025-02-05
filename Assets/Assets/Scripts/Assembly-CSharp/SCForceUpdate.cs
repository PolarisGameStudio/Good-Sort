using Falcon;

public class SCForceUpdate : SCMessage
{
	public int type;

	public string version;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
