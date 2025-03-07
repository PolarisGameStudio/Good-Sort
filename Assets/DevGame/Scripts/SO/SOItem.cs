using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "SOItem", menuName = "ScriptableObjects/SOItem", order = 1)]
public class SOItem : ScriptableObject
{
	public List<ItemAsset> items;

	public ItemAsset GetItemAsset(ItemType itemType)
	{
		foreach(var it in items)
		{
			if(itemType == it.type)
			{
				return it;
			}
		}
		return null;
	}

	public List<ItemType> GetItemTypes(List<ItemKind> filterKinds, List<ItemColor> filterColors)
	{
		return null;
	}

    public void SaveToFile()
    {
#if UNITY_EDITOR
        EditorUtility.SetDirty(this);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
#endif
    }
}
