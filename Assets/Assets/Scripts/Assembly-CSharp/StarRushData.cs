using System;
using System.Collections.Generic;

[Serializable]
public class StarRushData
{
	public int showTut;

	public int state;

	public int numUpdate;

	public long timeUpdate;

	public long timeEnd;

	public int powerup;

	public List<UserStarRushInfo> userInfos;

	public void Update(StarRushData starRushData)
	{
	}
}
