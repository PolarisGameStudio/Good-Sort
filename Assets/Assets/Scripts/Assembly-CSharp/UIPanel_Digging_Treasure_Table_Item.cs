using System;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_Digging_Treasure_Table_Item : MonoBehaviour
{
	public int ID;

	public bool IsReadyToClaim;

	public bool IsClaimed;

	public ItemInBoard Data;

	public RectTransform rectIcon;

	public Image iconBlank;

	public Image iconShadow;

	public Image iconIcon;

	[Header("Sprite Blank")]
	public Sprite[] sprIcons;

	public Sprite[] sprIcons_2;

	public Sprite[] sprBlanks;

	public Sprite[] sprShadows;

	private void OnDisable()
	{
	}

	public void SetItemData(int itemID)
	{
	}

	public void SetData(ItemInBoard data)
	{
	}

	public void Claimed()
	{
	}

	public void ReadyToClaim(ItemInBoard data)
	{
	}

	public void HomeComing(Action onComplete)
	{
	}
}
