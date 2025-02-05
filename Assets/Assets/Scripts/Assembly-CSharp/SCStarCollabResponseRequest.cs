using System.Collections.Generic;
using Falcon;

public class SCStarCollabResponseRequest : SCMessage
{
	public List<UserInfoStarCollab> userInfos;

	public int status;

	public int code;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
