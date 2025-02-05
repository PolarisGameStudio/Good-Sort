using System.Collections.Generic;
using Falcon;

public class SCGetFreeLivesData : SCMessage
{
	public List<FreeLiveRowData> data;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
