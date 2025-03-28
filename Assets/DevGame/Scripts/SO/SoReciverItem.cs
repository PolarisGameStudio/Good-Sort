using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[Serializable]
public struct ReciverItem
{
    public ResourceType type;
    public int numItem;
}

[Serializable]
public struct DataSoReciverItem
{
    public List<ResourceValue> reciverItems1;
    public int starLimit;
}

[CreateAssetMenu(fileName = "SoReciverItem", menuName = "ScriptableObjects/SoReciverItem", order = 2)]
public class SoReciverItem : ScriptableObject
{
    public List<DataSoReciverItem> dataSoReciverItems;

    public DataSoReciverItem GetDataSoReciverItemByStarAdd(int numStar)
    {
        dataSoReciverItems = dataSoReciverItems.OrderByDescending(x=>x.starLimit).ToList();

        foreach(var it in dataSoReciverItems)
        {
            if(numStar >= it.starLimit)
            {
                return it;
            }
        }

        DataSoReciverItem da = new();
        da.starLimit = -1;
        return da;
    }

    public void SetRetype()
    {
        foreach (var it in dataSoReciverItems)
        {
            foreach(var r in it.reciverItems1)
            {
                r.SetType();
            }    
        }
    }    

    public int GetStarLimit(int index)
    {
        if(index >= dataSoReciverItems.Count)
        {
            index = dataSoReciverItems.Count - 1;
        }   

        dataSoReciverItems = dataSoReciverItems.OrderBy(x => x.starLimit).ToList();
        return dataSoReciverItems[index].starLimit;
    }
}
