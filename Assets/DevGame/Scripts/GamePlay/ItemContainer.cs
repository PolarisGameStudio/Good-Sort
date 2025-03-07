using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class ItemContainer : MonoBehaviour
{

	public Action onLayerChange;

	[SerializeField]
	private Item _itemPrefab;

	private List<ListItemType> _itemTypes;


	private int _numLayerWhenInit;

	private Cell _cell;

	private bool _canSelect;

	public List<ListItemType> ItemTypes => _itemTypes;


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
				if (it.items[i] == 0)
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

				if (_cell.CellType == CellType.CellLayerCount || _cell.CellType == CellType.CellSingle)
				{
					indexCellTyeOneSlot++;
					layerItem.listItem[2] = item;
				}
				else
				{
					layerItem.listItem[index1] = item;
				}

				index1++;
				listItem.items.Add(item);
			}

			layerItem.SetCellType(_cell.CellType);
			index++;
		}

		if (_cell.CellType == CellType.CellLayerCount)
		{
			_cell.InitDotTypeCellOneSlot(indexCellTyeOneSlot);
		}
	}

	public LayerItem getCurrentLayer()
	{
		if (currentIndex < listLayerItem.Count && listLayerItem[currentIndex] != null)
		{
			return listLayerItem[currentIndex];
		}
		int index = 0;
		foreach (var it in listLayerItem)
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
	public LayerItem GetLayerByIndex(int index)
	{
		if (index >= listLayerItem.Count)
		{
			return null;
		}

		if (listLayerItem[index] == null)
		{
			int kk = 0;
		}

		return listLayerItem[index];
	}

	/// <summary>
	/// </summary>
	/// <param name="layerItem"></param>
	/// <param name="index"></param>
	/// <param name="listItem"></param>
	public void CreateLayerItem(LayerItem layerItem, List<Item> listItem, int index, bool isNormal, ref List<DataItemSkillSwap> dataItems)
	{
        if (listItem.Count == 2)
		{
			int kk = 0;
		}

		if (layerItem == null)
		{
			var gameObj = new GameObject();
			gameObj.transform.parent = transform;
			gameObj.transform.localPosition = Vector3.zero;
			gameObj.transform.localScale = Vector3.one;
			layerItem = gameObj.AddComponent<LayerItem>();
			layerItem.SetCellType(_cell.CellType);
			if (index < listLayerItem.Count && (listLayerItem[index] == null || listLayerItem[index].IsLayerAllPosBlank()))
			{
				listLayerItem[index] = layerItem;
				Debug.Log("NameNull: " + transform.parent.name);
			}
			else
			{
				Debug.Log("NameNull1: " + transform.parent.name + "_index: " + index);
				listLayerItem.Add(layerItem);
			}
		}
		layerItem.gameObject.name = "layer_" + index.ToString();
		layerItem.SetDataNull();

		int index1 = 0;

		foreach (var it in listItem)
		{
			it.transform.parent = layerItem.transform;

			it.SetItemContainer(this);

			DataItemSkillSwap da = new();
			da.isNomal = isNormal;
			da.item = it;
			if (_cell.CellType == CellType.CellLayerCount || _cell.CellType == CellType.CellSingle)
			{
				layerItem.listItem[0] = it;
				da.pointMove = it.GetPoinItem(index1, _cell.CellType);
			}
			else
			{
				layerItem.listItem[index1] = it;
				da.pointMove = it.GetPoinItem(index1, _cell.CellType);
			}
			index1++;
			it.EnableItemNormal(false);
			dataItems.Add(da);
		}
	}

	public void CreateLayerItemSkillSwap(List<List<Item>> listsIten, ref List<DataItemSkillSwap> dataItems)
	{
		var LayerShadow = GetLayerByIndex(currentIndex + 1);
		var LayerNormal = GetLayerByIndex(currentIndex);
		CreateLayerItem(LayerNormal, listsIten[0], currentIndex, true, ref dataItems);
		if (listsIten.Count > 1)
		{
			CreateLayerItem(LayerShadow, listsIten[1], currentIndex + 1, false, ref dataItems);
		}
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
		if (cc == null)
		{
			int kk = 0;
		}
		cc.RemoveItemInLayerItem(item);
	}

	public void AddItemInLayerItem(Item item, int index)
	{
		var cc = getCurrentLayer();

		if (cc == null)
		{
			return;
		}

		cc.AddItemInLayerItem(item, index);
	}

	public void RemoveDotTypeCellOneSlot()
	{
		if (_cell.CellType == CellType.CellLayerCount)
		{
			_cell.RemoveDotTypeCellOneSlot();
		}
	}

	public bool CheckLayerBank()
	{
		int count = 0;

		foreach (var it in listLayerItem)
		{
			if (it == null)
			{
				count++;

				continue;
			}

			if (!it.IsLayerAllPosBlank())
			{
				return false;
			}
		}

		if (count == listLayerItem.Count)
		{
			return true;
		}

		return true;
	}

	public void OnCheckSucessItem()
	{
		var currentLayer = getCurrentLayer();
		if (currentLayer == null)
		{
			return;
		}
		var items = getCurrentLayer().GetListItem();
		if (items.Count < 3)
		{
			return;
		}

		StartCoroutine(StartCheckMeger());
	}

	private IEnumerator StartCheckMeger()
	{
		yield return new WaitForSeconds(0.5f);
		CheckOnMegerSucess();
	}

	void OnCreateLayer()
	{
		var gameObj = new GameObject();
		gameObj.transform.parent = transform;
		gameObj.transform.localPosition = Vector3.zero;
		gameObj.transform.localScale = Vector3.one;
		var layerItem = gameObj.AddComponent<LayerItem>();
		layerItem.SetCellType(_cell.CellType);
		listLayerItem.Add(layerItem);
		currentIndex = 0;
	}


	public void OnSucessMegerItem(Item item)
	{
		if (listLayerItem.Count == 0)
		{
			OnCreateLayer();
		}
		if (currentIndex < listLayerItem.Count)
		{
			var currentLayer = listLayerItem[currentIndex];

			if (currentLayer.IsCheckDropItem())
			{
				item.itemContainer.RemoveIndexItemInLayerItem(item);

				//move to object
				var listIndex = currentLayer.GetListIndexPoint();
				float min = 9999999;
				Transform objEndeMove = null;

				List<Transform> listObjectMove = new();
				List<int> listIndexPointDrag = new();

				for (int i = 0; i < listIndex.Count; i++)
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

				for (int i = 0; i < listObjectMove.Count; i++)
				{
					var distance = Vector3.Distance(item.transform.position, listObjectMove[i].position);

					if (distance < min)
					{
						objEndeMove = listObjectMove[i];
						indexOfPointEndDrag = listIndexPointDrag[i];
						min = distance;
					}
				}

				if (objEndeMove != null)
				{
					Debug.Log("current_cell_current_" + item.itemContainer._cell.transform.name + "_" + item.itemContainer._cell.IsCheckCellBlank());
					var cellCurrent = item.itemContainer._cell;


					if (cellCurrent.MoveType == MoveType.Drop && cellCurrent.IsCheckCellBlank() && !item.itemContainer.Equals(item.itemContainerNew))
					{
						StartCoroutine(PlayAnimCellTypeDropBlank(cellCurrent));
					}


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

	public IEnumerator PlayAnimCellTypeDropBlank(Cell cell)
	{
		yield return new WaitForEndOfFrame();
        if (cell.MoveType == MoveType.Drop && cell.IsCheckCellBlank())
		{
            LogicGame.Instance.CheckRunAnimDrop(cell);
            yield return new WaitForSeconds(0.1f);
            Destroy(cell.gameObject);
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

        yield return new WaitForSeconds(0.4f);

		if (_cell.MoveType == MoveType.Drop)
		{
			LogicGame.Instance.CheckRunAnimDrop(_cell);
			yield return new WaitForSeconds(0.1f);
			Destroy(_cell.gameObject.gameObject);
		}

		if (isDesktroy)
		{
			OnDestroyLayerItem(trObj);
		}

        LogicGame.Instance.CheckGameOver();
    }

    public void OnNextLayerItem(bool isMeger)
	{
		var currentLayer = listLayerItem[currentIndex];

		if (isMeger)
		{
			if (currentLayer.IsMegerSucess())
			{

				LogicGame.Instance.CheckComboGame(_cell.transform.position);
				LogicGame.Instance.CheckObjectLock();
				currentIndex++;
				currentLayer.RemoveAllItem();

                AnimPlayGame.Instance.OnPlayAnimMegerSucess(Vector3.zero, _cell.transform);
                AnimPlayGame.Instance.OnPlayAnimCombo(Vector3.zero, LogicGame.Instance.CurrentCombo, _cell.transform);
                StartCoroutine(OnRunAnimMegerSucess(currentLayer, currentIndex != listLayerItem.Count - 1));
			}

			if (!currentLayer.IsLayerAllPosBlank())
			{
				return;
			}
		}

		if (!isMeger)
		{
			if (_cell.CellType == CellType.CellLayerCount)
			{
				if (currentIndex == listLayerItem.Count - 1)
				{
					currentLayer.RemoveAllItem();
				}
				else
				{
					OnDestroyLayerItem(currentLayer);
				}
			}

			currentIndex++;
		}

		if (currentIndex >= listLayerItem.Count)
		{
			currentIndex--;
			return;
		}

		if (listLayerItem[currentIndex].IsLayerAllPosBlank())
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

	private void OnDestroyLayerItem(LayerItem layer)
	{
		if (listLayerItem.Count <= 1)
		{
			return;
		}
		Destroy(layer.gameObject);
	}

	public void CheckOnMegerSucess()
	{
		OnNextLayerItem(true);
	}

	private void Update()
	{
		foreach (var it in listLayerItem)
		{
			if (it == null)
			{
				int cc = 0;
			}
		}
	}

	public bool IsItemLayersBlank()
	{
		foreach (var it in listLayerItem)
		{
			if (!it.IsLayerAllPosBlank())
			{
				return false;
			}
		}

		return true;
	}

	public List<Item> GetListItem(ItemType itemType, int num, int numLevelAdd)
	{
		List<Item> list = new List<Item>();
		for (int i = currentIndex + numLevelAdd; i < listLayerItem.Count; i++)
		{
			var items = listLayerItem[i].GetListItemByType(itemType);
			if (items != null && items.Count > 0)
			{
				list.AddRange(items);
			}

			if (list.Count >= num)
			{
				break;
			}
		}

		while (true)
		{
			if (list.Count > num)
			{
				list.RemoveAt(0);
			}
			else
			{
				break;
			}
		}

		return list;
	}

	public void CheckSetItemForSkill()
	{

		List<LayerItem> listLayers = new();
		List<int> listIndex = new();
		int index = 0;
		foreach (var it in listLayerItem)
		{
			if (it.IsLayerAllPosBlank())
			{
				listLayers.Add(it);
			}
		}


		foreach (var c in listLayers)
		{
			if (listLayerItem.Count > 1)
			{
				listLayerItem.Remove(c);
			}
		}

		List<LayerItem> listNewLayer = new();

		foreach (var it in listLayerItem)
		{
			if (it != null)
			{
				listNewLayer.Add(it);
			}
		}
		listLayerItem = listNewLayer;
		currentIndex = 0;
	}

	public List<Item> GetListItemForSkillSwap()
	{
		if (currentIndex >= listLayerItem.Count)
		{
			return null;
		}

		int indexCheck = CellType == CellType.CellLayerCount ? 1 : 2;
		int index = 0;
		List<Item> list = new List<Item>();

		for (int i = currentIndex; i < listLayerItem.Count; i++)
		{
			if (index >= indexCheck)
			{
				break;
			}
			index++;
			var items = listLayerItem[i].GetListItem();
			if (items != null && items.Count > 0)
			{
				list.AddRange(items);
				listLayerItem[i].SetDataNull();
			}
		}

		return list;
	}

	public List<Item> GetListItemForSkillBreakItem()
	{
		if(currentIndex >= listLayerItem.Count)
		{
			return null;
		}	

		return listLayerItem[currentIndex].GetListItem();
	}

	public List<Item> GetAllItemOfCell()
	{
		List<Item> Items = new();
		foreach(var it in listLayerItem)
		{
			Items.AddRange(it.GetListItem());
        }
		return Items;
	}	
}
