using System;
using System.Collections.Generic;

[Serializable]
public class CellInfo
{
	public int posX;

	public int posY;

	public int cellType;

	public int numberLayer;

	public int moveType;

	public float speed;

	public int isLock;

	public List<ItemsInLayerCell> itemsLayer;

	public CellType GetCellType()
	{
		return default(CellType);
	}

	public CellInfo()
	{
	}

	public CellInfo(CellInfo cellInfo)
	{
	}
}
