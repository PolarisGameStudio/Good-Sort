using Falcon;

public class ScNewAccount : SCMessage
{
	public int code;

	public string token;

	public string countryCode;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
