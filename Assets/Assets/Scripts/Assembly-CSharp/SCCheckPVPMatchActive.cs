using Falcon;

public class SCCheckPVPMatchActive : SCMessage
{
	public int state;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
