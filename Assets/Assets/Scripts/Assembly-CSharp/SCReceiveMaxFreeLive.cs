using System.Collections.Generic;
using Falcon;

public class SCReceiveMaxFreeLive : SCMessage
{
	public int status;

	public List<FreeLiveRowData> data;

	public int num;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
