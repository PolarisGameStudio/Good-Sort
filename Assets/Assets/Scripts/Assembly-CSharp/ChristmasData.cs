using System;
using System.Collections.Generic;

[Serializable]
public class ChristmasData
{
	[Serializable]
	public class LevelData
	{
		public List<TryData> failSaved;

		public List<int> currentLayer;

		public LevelData()
		{
		}

		public LevelData(int numCell)
		{
		}

		public LevelData(LevelData other)
		{
		}
	}

	[Serializable]
	public class TryData
	{
		public List<OneSlotTryData> lstOneSlotTryData;

		public TryData()
		{
		}

		public TryData(TryData other)
		{
		}
	}

	[Serializable]
	public class OneSlotTryData
	{
		public int itemIndex;

		public int isCorrect;

		public OneSlotTryData()
		{
		}

		public OneSlotTryData(int itemIndex, bool isCorrect)
		{
		}

		public OneSlotTryData(int itemIndex, int isCorrect)
		{
		}
	}

	public int isShowTut;

	public int isConfirmFinished;

	public int buyPack;



	public int currentLevel;

	public LevelData levelData;

	public List<int> rewardsCanClaim;

	public void Update(ChristmasDataServer data)
	{
	}
}
