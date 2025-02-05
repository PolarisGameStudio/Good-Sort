using System;
using System.Collections.Generic;

[Serializable]
public class ChristmasDataServer
{
	public int isShowTut;

	public int isConfirmFinished;

	public int buyPack;

	public int currentGiftHidden;

	public int totalSink;

	public int currentLevel;

	public ChristmasData.LevelData levelData;

	public List<int> rewardsCanClaim;

	public void Update(ChristmasData data)
	{
	}
}
