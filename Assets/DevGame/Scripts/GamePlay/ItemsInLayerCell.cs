using System;
using System.Collections.Generic;

[Serializable]
public class ItemsInLayerCell
{
	public List<int> items;

	public int GetIndexEmpty()
	{
		return 0;
	}

	public bool IsEmpty()
	{
		return false;
	}

	public int GetNumItem()
	{
		return 0;
	}
}
