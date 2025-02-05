using System;
using System.Collections.Generic;

[Serializable]
public class HalloweenDataServer
{
	public int state;

	public int buyPack;

	public int shovel;

	public int level;

	public int shovelUsed;

	public List<int> levelsReward;

	public BoardData boardData;

	public void Update(HalloweenData data)
	{
	}
}
