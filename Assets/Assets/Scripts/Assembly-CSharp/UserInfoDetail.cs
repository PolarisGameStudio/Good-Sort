using System;

[Serializable]
public class UserInfoDetail : UserSimpleInfo
{
	public TeamInfoSimple teamInfo;

	public int help_made;

	public int help_received;

	public long createdDate;

	public int firstTryWins;

	public int friendStatus;

	public int collectionCompleted;

	public int setCompleted;

	public int foodDuelScore;

	public FriendStatus GetFriendStatus()
	{
		return default(FriendStatus);
	}

	public string GetCreatedDate()
	{
		return null;
	}

	public int GetHelpMade()
	{
		return 0;
	}

	public int GetHelpReceived()
	{
		return 0;
	}

	public int GetFoodDuelScore()
	{
		return 0;
	}

	public int GetAreasCompleted()
	{
		return 0;
	}

	public int GetCollectionsCompleted()
	{
		return 0;
	}

	public int GetSetsCompleted()
	{
		return 0;
	}
}
