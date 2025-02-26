using System;
using System.Collections.Generic;

[Serializable]
public class CollectionData
{
	public int tutState;

	public int rewardState;

	public List<CardSet> cardSets;


	public long timeEnd;

	public int season;

	public List<int> badges;

	public int numSend;

	public long timeResetSend;

	public int collectionCompleted;

	public int setCompleted;

	public void Update(CollectionDataServer collectionData)
	{
	}
}
