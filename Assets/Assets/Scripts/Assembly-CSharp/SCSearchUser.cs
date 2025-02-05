using System.Collections.Generic;
using Falcon;

public class SCSearchUser : SCMessage
{
	public List<UserInfoSearch> users;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
