using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItemAsset
{
	public ItemType type;

	public Sprite sprite;

	public Sprite spriteHidden;

	public ItemKind kind;

	public ItemColor[] colors;

	public bool ContainColor(List<ItemColor> filterColors)
	{
		return false;
	}
}
