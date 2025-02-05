using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class ItemContainer : MonoBehaviour
{

	public Action onLayerChange;

	[SerializeField]
	private Item _itemPrefab;

	private List<ListItemType> _itemTypes;

	private List<ListItem> _items = new();

	private int _numLayerWhenInit;

	private Cell _cell;

	private bool _canSelect;

	public List<ListItemType> ItemTypes => _itemTypes;

	public List<ListItem> Items => _items;

	public int NumLayerWhenInit => _numLayerWhenInit;

	public Cell Cell => _cell;

	public CellType CellType => default(CellType);

	public bool IsLock => false;

	public Dictionary<GameObject, Item> listPointItem = new();

	public List<Transform> listPintDrag = null;

	public List<LayerItem> listLayerItem = new();

	public int currentIndex = 0;


	public bool CanSelect()
	{
		return false;
	}

	private void Awake()
	{

	}

	public void SetupItem(Cell cell, List<ItemsInLayerCell> itemInfos)
	{
		int index = 0;
        foreach (var it in itemInfos)
        {
			var listItem = new ListItem();
			int index1 = 0;

            var gameObj = new GameObject();
			gameObj.transform.parent = transform;
            gameObj.transform.localPosition = Vector3.zero;
			gameObj.name = "layer_" + index.ToString();
			var layerItem = gameObj.AddComponent<LayerItem>();
            listLayerItem.Add(layerItem);

            for (int i = 0; i < it.items.Count; i++)
            {
				if(it.items[i] == 0)
				{
                    listItem.items.Add(null);
                    layerItem.listItem[i] = null;
                    index1++;
                    continue;
				}

                var DataItem = SOItemContainer.Instance.GetItemAsset(it.items[i]);
				var objItem = Instantiate(_itemPrefab.gameObject, gameObj.transform);
				var item = objItem.GetComponent<Item>();
				item.Setup(this, DataItem, index == 0, index1, index);
                layerItem.listItem[i] = item;
                // listPointItem.Add(objItem.transform.position, item);

                index1++;
                listItem.items.Add(item);
            }
			_items.Add(listItem);
            index++;
        }
    }

	public void OnSucessMegerItem(Item item)
	{
		if(currentIndex < listLayerItem.Count)
		{
			var currentLayer = listLayerItem[currentIndex];

			if(currentLayer.IsCheckDropItem())
			{
				//move to object
				var listIndex = currentLayer.GetListIndexPoint();
				float min = 9999999;
				Transform objEndeMove = null;

				List<Transform> listObjectMove = new();

				for(int i = 0; i < listIndex.Count; i++)
				{
					listObjectMove.Add(listPintDrag[listIndex[i]]);
                }

				for(int i = 0; i < listObjectMove.Count; i++)
				{
					var distance = Vector3.Distance(item.transform.position, listObjectMove[i].position);

					if(distance < min)
					{
						objEndeMove = listObjectMove[i];
                        min = distance;
                    }
				}

				if(objEndeMove != null)
				{
                    item.transform.position = objEndeMove.position;
                }

            }
			else
			{
				item.OnMoveFailed();
            }
		}
		else
		{
            item.OnMoveFailed();
        }
	}
}
