using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public class HalloweenData
{
	public int state;

	public int buyPack;

	public ObscuredInt shovel;

	public ObscuredInt level;

	public int shovelUsed;

	public List<int> levelsReward;

	public BoardData boardData;

	public void Update(HalloweenDataServer data)
	{
	}
}
