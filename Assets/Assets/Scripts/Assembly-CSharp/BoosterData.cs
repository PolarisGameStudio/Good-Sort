using System;
using CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public class BoosterData
{
	public ObscuredInt[] booster;

	public ObscuredInt[] boosterFree;

	public long[] timeInfis;

	public void Update(BoosterDataServer boosterData)
	{
	}
}
