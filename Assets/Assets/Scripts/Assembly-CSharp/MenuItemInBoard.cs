using System.Collections.Generic;
using UnityEngine;

public class MenuItemInBoard : MonoBehaviour
{
	public static Dictionary<ItemType, int> dictItems;

	public static Dictionary<int, Dictionary<ItemType, int>> dictItemsByLayer;

	[SerializeField]
	private RectTransform _content;

	[SerializeField]
	private GameObject _itemExample;

	[SerializeField]
	private SOItem _soItem;

	private GoodSortEditorBoard _board => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public static bool LevelIsValid()
	{
		return false;
	}

	private void UpdateUI(GoodSortEditorItem item)
	{
	}

	private void UpdateUIT()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateDictItems()
	{
	}

	private Sprite GetSpriteFromSO(ItemType itemType)
	{
		return null;
	}
}
