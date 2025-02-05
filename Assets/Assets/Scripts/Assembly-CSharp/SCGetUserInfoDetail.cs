using Falcon;

public class SCGetUserInfoDetail : SCMessage
{
	public UserInfoDetail userInfo;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
