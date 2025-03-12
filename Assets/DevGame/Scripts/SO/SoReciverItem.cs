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
}
