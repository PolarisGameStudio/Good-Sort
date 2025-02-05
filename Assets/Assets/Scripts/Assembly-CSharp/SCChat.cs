using Falcon;

public class SCChat : SCMessage
{
	public long id;

	public string t;

	public byte p;

	public SCChat()
	{
	}

	public SCChat(string text)
	{
	}

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
