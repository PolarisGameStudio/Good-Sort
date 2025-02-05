using System;

[Serializable]
public class UserStarRushInfo : UserProfile
{
	public int type;

	public int rank;

	public int preRank;

	public int star;

	public int preStar;

	public bool yourSelf;

	public bool golden;

	public UserStarRushInfo()
	{
	}

	public UserStarRushInfo(UserStarRushInfo userStarRush)
	{
	}
}
