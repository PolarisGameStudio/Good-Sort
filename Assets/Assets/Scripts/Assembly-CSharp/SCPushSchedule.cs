using System.Collections.Generic;
using Falcon;

public class SCPushSchedule : SCMessage
{
	public List<PushSchedule> push_schedules;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
