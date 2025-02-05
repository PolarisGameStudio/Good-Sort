using Falcon;

public class SCBindDataRsp : SCMessage
{
	public string bind_type;

	public string bind_id;

	public string bind_data;

	public string bind_status;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
