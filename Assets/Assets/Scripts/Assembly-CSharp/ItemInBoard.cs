using System;
using UnityEngine;

[Serializable]
public class ItemInBoard
{
	public Position pos;

	public int itemId;

	public int rotate;

	public Vector2Int GetSize()
	{
		return default(Vector2Int);
	}

	public Vector2Int GetSizeWhenRotate()
	{
		return default(Vector2Int);
	}
}
