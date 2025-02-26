using System;
using System.Collections.Generic;

[Serializable]
public class MasterPass
{
	public int tutState;




	public List<int> rewardFrees;

	public List<int> rewardPaids;

	public long timeEnd;


	public int tierPurchase;

	public int numPurchase;

	public void Update(MasterPassServer masterPass)
	{
	}
}
