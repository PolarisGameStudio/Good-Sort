using System;

[Serializable]
public class CartRaceUserInfo : UserProfile
{
	public int level;

	public int preLevel;

	public bool yourSelf;

	public bool golden;

	public long timeCpl;

	public CartRaceUserInfo()
	{
	}

	public CartRaceUserInfo(CartRaceUserInfo user)
	{
	}
}
