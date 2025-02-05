using System;
using System.Collections.Generic;

[Serializable]
public class ListItemType
{
	public List<ItemType> items;

	public int GetIndexEmpty()
	{
		return 0;
	}

	public int GetNumItem()
	{
		return 0;
	}

	public int GetNumItemWithoutGoldenGift()
	{
		return 0;
	}

	public bool IsFull()
	{
		return false;
	}

	public bool IsEmpty()
	{
		return false;
	}
}
