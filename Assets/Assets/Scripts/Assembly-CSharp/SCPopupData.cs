using Falcon;

public class SCPopupData : SCMessage
{
	public int type;

	public string title;

	public string content;

	public string url;

	public int action;

	public int canClose;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
