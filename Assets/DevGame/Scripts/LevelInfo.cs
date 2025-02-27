using System;
using System.Collections.Generic;

[Serializable]
public class LevelInfo
{
	public int timeToPlay;

	public int numberCellLock;

	public int itemHiden;

	public List<CellInfo> cells;

	public LevelInfo()
	{
	}

	public LevelInfo(LevelInfo levelInfo)
	{
	}

	public bool IsValidLevel(string name = null)
	{
		return false;
	}

	public void ValidateLevel(string name)
	{
	}
}
