using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public class MasterPass
{
	public int tutState;

	public ObscuredInt key;

	public ObscuredInt preKey;

	public ObscuredInt preKeyHome;

	public List<int> rewardFrees;

	public List<int> rewardPaids;

	public long timeEnd;

	public ObscuredInt purchaseState;

	public int tierPurchase;

	public int numPurchase;

	public void Update(MasterPassServer masterPass)
	{
	}
}
