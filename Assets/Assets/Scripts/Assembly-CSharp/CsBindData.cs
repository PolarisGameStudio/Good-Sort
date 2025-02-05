using Falcon;

public class CsBindData : CSMessage
{
	public string bind_type;

	public string bind_id;

	public string bind_data;

	public CsBindData(string bind_type, string bind_id, string bind_data)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
