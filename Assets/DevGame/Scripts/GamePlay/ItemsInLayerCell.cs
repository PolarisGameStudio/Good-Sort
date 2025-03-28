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

	public void ShuffeItem()
	{
		List<int> list = new List<int>();
		foreach(var it in items)
		{
			if(it != 0)
			{
                list.Add(it);
            }
		}

		if(list.Count == 2)
		{
			HelperManager.Shuffle(items);
		}
	}
}
