using System;
using CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public class PiggyBank
{
	public ObscuredInt gold;

	public long timeBuy;

	public long timeReset;

	public int numResetByTimeout;

	public void Update(PiggyBankServer piggyBank)
	{
	}
}
