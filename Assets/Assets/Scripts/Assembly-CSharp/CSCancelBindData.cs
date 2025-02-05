using Falcon;

public class CSCancelBindData : CSMessage
{
	public string id;

	public int type;

	public CSCancelBindData(string id, int type)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
