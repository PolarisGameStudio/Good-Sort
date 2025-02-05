using System.Collections.Generic;
using UnityEngine;

public static class InGameDataConst
{
	public const string POOL_ITEM = "Item";

	public static readonly Dictionary<CellType, int> NumLayerAppear;

	public static readonly float Distance2ItemInCell;

	public static readonly Dictionary<CellType, Vector2> CellSizePerSlot;

	public static readonly Dictionary<CellType, Vector2> CellSize;

	public static readonly Dictionary<CellType, Vector2Int> CellSizeUnit;

	public static readonly Dictionary<CellType, Vector2Int> CellSizeContain;
}
