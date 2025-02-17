using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LayerItem : MonoBehaviour
{
    public CellType cellType;

    public List<Item> listItem = new() { null, null, null};

    public bool IsCheckDropItem()
    {
        for(int i = 0; i < listItem.Count; i++)
        {
            if (listItem[i] == null)
            {
                return true;
            }
        }

        return false;
    }

    public List<int> GetListIndexPoint()
    {
        List<int> listPoint = new();

        for (int i = 0; i < listItem.Count; i++)
        {
            if (listItem[i] == null)
            {
                listPoint.Add(i);
            }
        }

        return listPoint;
    }

    public void RemoveItemInLayerItem(Item item)
    {
        for(int i = 0; i < listItem.Count; i++)
        {
            if (item.Equals(listItem[i]))
            {
                listItem[i] = null;
                break;
            }
        }
    }

    public void AddItemInLayerItem(Item item, int index)
    {
        if(this == null)
        {
            int kk = 0;
        }

        if(index >= listItem.Count || this == null)
        {
            return;
        }

        if (listItem[index] == null)
        {
            listItem[index] = item;
            item.transform.parent = transform;
        }
    }

    public bool IsLayerAllPosBlank()
    {
        for (int i = 0; i < listItem.Count; i++)
        {
            if (listItem[i] != null)
            {
                return false;
            }
        }

        return true;
    }    

    public bool IsMegerSucess()
    {
        if(cellType == CellType.CellLayerCount || cellType == CellType.CellSingle)
        {
            return false;
        }

        for (int i = 0; i < listItem.Count; i++)
        {
            if (listItem[i] == null)
            {
                return false;
            }
        }

        var type = listItem[0].ItemType;

        for (int i = 1; i < listItem.Count; i++)
        {
            if (listItem[i].ItemType != type)
            {
                return false;
            }
        }

        return true;
    }

    public void RemoveAllItem()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            var gameObject = transform.GetChild(i).gameObject;
            Destroy(gameObject);
        }

        for(int i = 0; i < listItem.Count; i++)
        {
            listItem[i] = null;
        }
    }

    public void OnNextItemNormal()
    {
        for(int i = 0; i < listItem.Count; i++)
        {
            if (listItem[i] == null)
            {
                continue;
            }
            listItem[i].EnableItemNormal(true);
        }
    }

    public void OnNextItemShadow()
    {
        for (int i = 0; i < listItem.Count; i++)
        {
            if (listItem[i] == null)
            {
                continue;
            }
            listItem[i].EnableItemShadow(true);
        }
    }

    public void OnLockItem()
    {
        for (int i = 0; i < listItem.Count; i++)
        {
            if (listItem[i] != null)
            {
                listItem[i].OnLockItem();
            }
        }
    }

    public void OnUnlockItem()
    {
        for (int i = 0; i < listItem.Count; i++)
        {
            if (listItem[i] != null)
            {
                listItem[i].OnUnlockItem();
            }
        }
    }

    public void SetCellType(CellType ce)
    {
        cellType = ce;
        if(cellType == CellType.CellLayerCount || cellType == CellType.CellSingle)
        {
            listItem.RemoveAt(0);
            listItem.RemoveAt(0);
        }
    }

    public List<Item> GetListItem()
    {
        var newListItem = listItem.Where(x => x != null).ToList();
        return newListItem;
    }

    public List<Item> GetListItemByType(ItemType item)
    {
        var newListItem = listItem.Where(x => x != null && x.ItemType == item).ToList();
        return newListItem;
    }
}
