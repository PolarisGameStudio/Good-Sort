using UnityEngine;

public class UIPanel_Digging_Tile : MonoBehaviour
{
	[Header("Base")]
	public RectTransform rectTransformTile;

	public UIPanel_Digging_TileMapRenderer Manager;

	public CellBoardType Type;

	public bool IsBroken;

	public int itemIndex;

	public int itemRow;

	public int itemColum;

	public bool HasTileAbove;

	public bool HasTileBelow;

	public bool HasTileLeft;

	public bool HasTileRight;

	public void SetNeighborStatus(bool above, bool below, bool left, bool right)
	{
	}

	public void SetItemIndex(int index, int col, int row)
	{
	}

	public virtual void SetItemData(UIPanel_Digging_TileMapRenderer manager, CellBoardType type)
	{
	}

	public virtual void RefreshTile(int indexCellBoardType)
	{
	}

	public (int, int) GetPositionInMapTile()
	{
		return default((int, int));
	}

	public void DigTile()
	{
	}
}
