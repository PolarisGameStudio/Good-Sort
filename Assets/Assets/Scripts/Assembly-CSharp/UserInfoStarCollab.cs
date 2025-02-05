using System;
using System.Collections.Generic;

[Serializable]
public class UserInfoStarCollab : UserSimpleInfo
{
	public int myScore;

	public int partnerScore;

	public int preScore;

	public int score;

	public int milkFromPartner;

	public int state;

	public List<int> rewards;
}
