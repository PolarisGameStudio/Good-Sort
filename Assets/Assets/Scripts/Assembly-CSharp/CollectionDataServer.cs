using System;
using System.Collections.Generic;

[Serializable]
public class CollectionDataServer
{
	public int tutState;

	public int rewardState;

	public List<CardSet> cardSets;

	public int star;

	public long timeEnd;

	public int season;

	public List<int> badges;

	public int numSend;

	public long timeResetSend;

	public int collectionCompleted;

	public int setCompleted;

	public void Update(CollectionData collectionData)
	{
	}

	public void OpenPack(CollectionPack collectionPack, int num)
	{
	}

	public void ResetData()
	{
	}

	public void FullSet()
	{
	}

	public void ShowCardNew()
	{
	}
}
