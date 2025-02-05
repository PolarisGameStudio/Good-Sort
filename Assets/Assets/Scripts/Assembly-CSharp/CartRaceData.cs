using System;
using System.Collections.Generic;

[Serializable]
public class CartRaceData
{
	public int justWinLevel;

	public int showTut;

	public int state;

	public long timeEnd;

	public int powerup;

	public int numPlayInSession;

	public int botType;

	public List<CartRaceUserInfo> userInfos;

	public void Update(CartRaceData cartRace)
	{
	}
}
