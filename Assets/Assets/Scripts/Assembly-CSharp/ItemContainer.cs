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

	private CellType _cellType;
	public CellType CellType => _cellType;

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
        _cellType = cell.CellType;
        _cell = cell;
        int index = 0;

		int indexCellTyeOneSlot = 0;

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
				item.Setup(this, DataItem, index == 0, index1, index, _cell.CellType);

				if(_cell.CellType == CellType.CellLayerCount || _cell.CellType == CellType.CellSingle)
				{
                    indexCellTyeOneSlot++;
                    layerItem.listItem[2] = item;
                }
				else
				{
                    layerItem.listItem[index1] = item;
                }

                // listPointItem.Add(objItem.transform.position, item);

                index1++;
                listItem.items.Add(item);
            }

			layerItem.SetCellType(_cell.CellType);

            _items.Add(listItem);
            index++;
        }

        if (_cell.CellType == CellType.CellLayerCount)
		{
			_cell.InitDotTypeCellOneSlot(indexCellTyeOneSlot);
        }
    }

    LayerItem getCurrentLayer()
	{
		if(listLayerItem[currentIndex] != null)
		{
			return listLayerItem[currentIndex];
		}
		int index = 0;
		foreach(var it in listLayerItem)
		{
            if (it != null)
			{
                currentIndex = index;
                return it;
            }
            index++;
        }
		return null;
    }

    public void OnLockCell()
	{
		var cc = getCurrentLayer();
        cc.OnLockItem();
    }

    public void UnLockCell()
	{
        var cc = getCurrentLayer();
        cc.OnUnlockItem();
    }

    public void RemoveIndexItemInLayerItem(Item item)
	{
        var cc = getCurrentLayer();
        cc.RemoveItemInLayerItem(item);
    }

    public void AddItemInLayerItem(Item item, int index)
	{
        var cc = getCurrentLayer();

		if(cc == null)
		{
			return;
		}

        cc.AddItemInLayerItem(item, index);
    }

	public void RemoveDotTypeCellOneSlot()
	{
		if(_cell.CellType == CellType.CellLayerCount)
		{
            _cell.RemoveDotTypeCellOneSlot();
        }
    }

	public bool CheckLayerBank()
	{
		int count = 0;

		foreach(var it in listLayerItem)
		{
			if(it == null)
			{
				count++;

                continue;
			}

			if(!it.IsLayerAllPosBlank())
			{
				return false;
			}
		}

		if(count == listLayerItem.Count)
		{
			return true;
		}	

		return true;
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
					if (_cell.CellType == CellType.CellLayerCount || _cell.CellType == CellType.CellSingle)
					{
                        listObjectMove.Add(listPintDrag[0]);
                        listIndexPointDrag.Add(listIndex[i]);
                    }
					else
					{
                        listObjectMove.Add(listPintDrag[listIndex[i]]);
                        listIndexPointDrag.Add(listIndex[i]);
                    }
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

				if (objEndeMove != null)
				{
                    item.itemContainerNew.AddItemInLayerItem(item, indexOfPointEndDrag);
                    var curentParent = objEndeMove.transform.parent;
                    objEndeMove.transform.parent = item.transform.parent;
					var point = objEndeMove.transform.localPosition;
					objEndeMove.transform.parent = curentParent;

                    item.OnRemoveDotCellTypeOneSlot();
                    item.OnNextLayerItemCurrentContainer();
                    item.OnUpdateItemContainer();
                    item.OnMoveWhenEndDrag(point, true, () => {
                        CheckOnMegerSucess();
                    });
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

	IEnumerator OnRunAnimMegerSucess(LayerItem trObj, bool isDesktroy)
	{
        for (int i = 0; i < trObj.transform.childCount; i++)
		{
			var child = trObj.transform.GetChild(i).GetComponent<Item>();
			child.RunAnimScale(null);

        }

        AnimPlayGame.Instance.OnPlayAnimMegerSucess(Vector3.zero, _cell.transform);

        yield return new WaitForSeconds(0.2f);

		if(_cell.MoveType == MoveType.Drop)
		{
            LogicGame.Instance.CheckRunAnimDrop(_cell);
        }

        if (isDesktroy)
		{
            Destroy(trObj.gameObject);
        }
    }

    public void OnNextLayerItem(bool isMeger)
	{
        var currentLayer = listLayerItem[currentIndex];

        if (isMeger)
        {
			if (currentLayer.IsMegerSucess())
			{
                LogicGame.Instance.CheckObjectLock();
                currentIndex++;
                currentLayer.RemoveAllItem();
                StartCoroutine(OnRunAnimMegerSucess(currentLayer, currentIndex != listLayerItem.Count - 1));
            }

			if(!currentLayer.IsLayerAllPosBlank())
			{
				return;
			}
        }


		if(transform.parent.name == "3,5")
		{
			int kk = 0;
		}

		if(!isMeger)
		{
            if (_cell.CellType == CellType.CellLayerCount)
            {
                if (currentIndex == listLayerItem.Count - 1)
                {
                    currentLayer.RemoveAllItem();
                }
                else
                {
                    Destroy(currentLayer.gameObject);
                }
            }

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
