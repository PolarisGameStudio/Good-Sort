using UnityEngine;

public class UIPanel_Digging_Level : MonoBehaviour
{
	public int indexLevel;

	public RectTransform rectTransform;

	public UIPanel_Digging_TileMapRenderer tileMap;

	public UIPanel_Digging_Treasure_Table treasureTable;

	public static UIPanel_Digging_TileMapRenderer s_TileMapSelected;

	private bool IsInitTile;

	private void OnDestroy()
	{
	}

	public void UpdateUI(int level)
	{
	}
}
