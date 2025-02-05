using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SOItemBase", menuName = "ScriptableObjects/SOItemBase", order = 4)]
public class SOItemBase : ScriptableObject
{
	public List<ItemBase> itemBases;

	public List<ItemType> GetItemTypes(string name)
	{
		return null;
	}
}
