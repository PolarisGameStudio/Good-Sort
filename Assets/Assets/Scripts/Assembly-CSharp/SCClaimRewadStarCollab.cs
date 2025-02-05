using Falcon;

public class SCClaimRewadStarCollab : SCMessage
{
	public int collabIndex;

	public int rewardIndex;

	public UserInfoStarCollab userInfo;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
