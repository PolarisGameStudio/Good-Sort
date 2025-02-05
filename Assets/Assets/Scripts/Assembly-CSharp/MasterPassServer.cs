using System;
using System.Collections.Generic;

[Serializable]
public class MasterPassServer
{
	public int tutState;

	public int key;

	public int preKey;

	public int preKeyHome;

	public List<int> rewardFrees;

	public List<int> rewardPaids;

	public long timeEnd;

	public int purchaseState;

	public int tierPurchase;

	public int numPurchase;

	public void Update(MasterPass masterPass)
	{
	}
}
