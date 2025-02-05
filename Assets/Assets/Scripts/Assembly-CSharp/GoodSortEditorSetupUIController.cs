using System.Collections.Generic;
using UnityEngine;

public class GoodSortEditorSetupUIController : Singleton<GoodSortEditorSetupUIController>
{
	private List<GameObject> _listCells;

	private List<GameObject> _listItems;

	private List<GoodSortEditorItem> _listItemGoodSort;

	[SerializeField]
	private SOItem _item;

	[SerializeField]
	private SOCell _soCell;

	[SerializeField]
	private GameObject _defaultPrefabItem;

	[SerializeField]
	private Transform _parentItems;

	[SerializeField]
	private Transform _parentCells;

	public Transform iconLock;

	public Dictionary<ItemType, int> itemsAdded;

	private const int numItem = 3;

	public void Add(ItemType itemType, bool callback = true)
	{
	}

	public void Remove(ItemType itemType)
	{
	}

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void SetupListCellAndItem()
	{
	}

	private void SetupListFromPath(out List<GameObject> listGO)
	{
		listGO = null;
	}

	private void SetupListFromSO(out List<GameObject> listGO)
	{
		listGO = null;
	}

	private void SetupListPrefabItems()
	{
	}

	public GoodSortEditorItem GetItem(ItemType itemType)
	{
		return null;
	}
}
