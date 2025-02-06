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

		if(cell.gameObject.name == "0,3")
		{
			int kk = 0;
		}	

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
                    layerItem.listItem[index1] = null;
                    index1++;
                    continue;
				}

                var DataItem = SOItemContainer.Instance.GetItemAsset(it.items[i]);
				var objItem = Instantiate(_itemPrefab.gameObject, gameObj.transform);
				var item = objItem.GetComponent<Item>();
				item.Setup(this, DataItem, index == 0, index1, index);
                layerItem.listItem[index1] = item;
                // listPointItem.Add(objItem.transform.position, item);

                index1++;
                listItem.items.Add(item);
            }
			_items.Add(listItem);
            index++;
        }
    }

	public void RemoveIndexItemInLayerItem(Item item)
	{
		listLayerItem[currentIndex].RemoveItemInLayerItem(item);
    }

    public void AddItemInLayerItem(Item item, int index)
	{
        listLayerItem[currentIndex].AddItemInLayerItem(item, index);
    }


    public void OnSucessMegerItem(Item item)
	{
		if(currentIndex < listLayerItem.Count)
		{
			var currentLayer = listLayerItem[currentIndex];

			if(currentLayer.IsCheckDropItem())
			{
				item.itemContainer.RemoveIndexItemInLayerItem(item);

                //move to object
                var listIndex = currentLayer.GetListIndexPoint();
				float min = 9999999;
				Transform objEndeMove = null;

				List<Transform> listObjectMove = new();
				List<int> listIndexPointDrag = new();

				for(int i = 0; i < listIndex.Count; i++)
				{
					listObjectMove.Add(listPintDrag[listIndex[i]]);
					listIndexPointDrag.Add(listIndex[i]);
                }

				int indexOfPointEndDrag = 0;

				for(int i = 0; i < listObjectMove.Count; i++)
				{
					var distance = Vector3.Distance(item.transform.position, listObjectMove[i].position);

					if(distance < min)
					{
						objEndeMove = listObjectMove[i];
						indexOfPointEndDrag = listIndexPointDrag[i];
                        min = distance;
                    }
				}

				if(objEndeMove != null)
				{
                    item.transform.position = objEndeMove.position;
					item.itemContainerNew.AddItemInLayerItem(item, indexOfPointEndDrag);
					item.OnNextLayerItemCurrentContainer();
                    item.OnUpdateItemContainer();
					CheckOnMegerSucess();
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

	public void OnNextItemWhenMove()
	{
		if (listLayerItem[currentIndex].IsLayerAllPosBlank())
		{
            OnNextLayerItem(false);
        }
	}

	public void OnNextLayerItem(bool isMeger)
	{
        var currentLayer = listLayerItem[currentIndex];

        if (currentLayer.IsMegerSucess() && isMeger)
        {
            if (currentIndex == listLayerItem.Count - 1)
            {
                currentLayer.RemoveAllItem();
            }
            else
            {
                Destroy(currentLayer.gameObject);
                currentIndex++;
            }

        }

		if(!isMeger)
		{
			currentIndex++;
        }

        if (currentIndex >= listLayerItem.Count)
        {
			currentIndex--;
            return;
        }

        listLayerItem[currentIndex].OnNextItemNormal();

        if (currentIndex + 1 >= listLayerItem.Count)
        {
            return;
        }

        listLayerItem[currentIndex + 1].OnNextItemShadow();
    }

	public void CheckOnMegerSucess()
	{
		OnNextLayerItem(true);
    }

	public bool IsItemLayersBlank()
	{
		foreach(var it in listLayerItem)
		{
			if(!it.IsLayerAllPosBlank())
			{
				return false;
			}
		}

		return true;
	}
}
