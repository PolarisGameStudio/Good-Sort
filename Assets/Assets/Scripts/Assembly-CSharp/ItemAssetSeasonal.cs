using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItemAssetSeasonal
{
	public Sprite sprite;

	public Sprite spriteHidden;

	public ItemColor[] colors;

	public bool ContainColor(List<ItemColor> filterColors)
	{
		return false;
	}
}
