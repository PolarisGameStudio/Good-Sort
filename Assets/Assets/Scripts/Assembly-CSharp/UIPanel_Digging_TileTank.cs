using UnityEngine;
using UnityEngine.UI;

public class UIPanel_Digging_TileTank : UIPanel_Digging_TileShadow
{
	[Header("Tile - Tank Props")]
	public Button btnSelectBlock;

	public Sprite[] sprHps;

	public override void RefreshTile(int currentIndexCellBoardType)
	{
	}

	public override void SetItemData(UIPanel_Digging_TileMapRenderer manager, CellBoardType type)
	{
	}

	private void UpdateUI_HP(CellBoardType type)
	{
	}
}
