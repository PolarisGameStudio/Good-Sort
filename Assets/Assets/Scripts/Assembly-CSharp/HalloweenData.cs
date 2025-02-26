using System;
using System.Collections.Generic;

[Serializable]
public class HalloweenData
{
	public int state;

	public int buyPack;



	public int shovelUsed;

	public List<int> levelsReward;

	public BoardData boardData;

	public void Update(HalloweenDataServer data)
	{
	}
}
