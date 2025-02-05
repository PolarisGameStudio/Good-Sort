using Falcon;

public class CSClaimRewadStarCollab : CSMessage
{
	public int collabIndex;

	public int rewardIndex;

	public CSClaimRewadStarCollab(int collabIndex, int rewardIndex)
	{
	}

	public override string GetEvent()
	{
		return null;
	}
}
