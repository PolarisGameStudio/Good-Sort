using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SOCell", menuName = "ScriptableObjects/Cell", order = 2)]
public class SOCell : ScriptableObject
{
	public List<CellAsset> cellAssets;

	public CellAsset GetCellAsset(CellType cellType)
	{
		foreach(var it in cellAssets)
		{
			if(it.cellType == cellType)
			{
				return it;
			}
		}
		return null;
	}
}
