using System.Collections.Generic;
using Falcon;

public class SCCheckStarCollab : SCMessage
{
	public int state;

	public long timeEnd;

	public int grandReward;

	public int numEmptySlot;

	public List<UserInfoStarCollab> userInfos;

	public int milk;

	public override string GetEvent()
	{
		return null;
	}

	public override void OnData()
	{
	}
}
