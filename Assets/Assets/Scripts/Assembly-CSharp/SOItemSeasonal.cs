using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SOItem", menuName = "ScriptableObjects/SOItemSeasonal", order = 1)]
public class SOItemSeasonal : ScriptableObject
{
	public List<ItemAssetSeasonal> items;

	public void InitItemChristmass(Sprite[] sprites)
	{
	}
}
