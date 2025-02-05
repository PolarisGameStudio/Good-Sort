using UnityEngine;
using UnityEngine.UI;

public class UIPanel_Digging_TileShadow : UIPanel_Digging_Tile
{
	[Header("Shadow")]
	public Image iconShadow;

	[Header("Shadow - Sprite")]
	public Sprite sprShadowABLR;

	public Sprite sprShadowABL;

	public Sprite sprShadowABR;

	public Sprite sprShadowLRA;

	public Sprite sprShadowLRB;

	public Sprite sprShadowAB;

	public Sprite sprShadowLR;

	public Sprite sprShadowAL;

	public Sprite sprShadowAR;

	public Sprite sprShadowBL;

	public Sprite sprShadowBR;

	public Sprite sprShadowA;

	public Sprite sprShadowB;

	public Sprite sprShadowL;

	public Sprite sprShadowR;

	[Header("Shadow Corner")]
	public RectTransform rectShadowCornerAL;

	public RectTransform rectShadowCornerAR;

	public RectTransform rectShadowCornerBL;

	public RectTransform rectShadowCornerBR;

	public override void SetItemData(UIPanel_Digging_TileMapRenderer manager, CellBoardType type)
	{
	}

	public void UpdateSpriteShadow()
	{
	}

	public void UpdateShadowCorner()
	{
	}
}
