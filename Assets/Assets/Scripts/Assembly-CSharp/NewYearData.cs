using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public class NewYearData
{
	public ObscuredInt wine;

	public int index;

	public int userType;

	public List<int> canClaimIndexs;

	public int season;

	public void Update(NewYearDataServer data)
	{
	}
}
