using System;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_Digging_TileMapRenderer : MonoBehaviour
{
	public static UIPanel_Digging_Tile s_TileSelected;

	public RectTransform rectTreasureBehindTile;

	public GridLayoutGroup rectGridTile;

	[Header("Tile")]
	public UIPanel_Digging_Tile prefabTileNormal;

	public UIPanel_Digging_Tile prefabTileTank;

	public UIPanel_Digging_Tile prefabTileBlank;

	[Header("Do not assign")]
	public UIPanel_Digging_Tile[] tiles;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void InitTileMap(int level, Action OnComplete)
	{
	}

	public void UpdateUI_ActiveTiles(IntArray[] data)
	{
	}

	public void UpdateUI_DeactiveTiles()
	{
	}

	public void RefreshUI_AllPropsTileMap()
	{
	}
}
