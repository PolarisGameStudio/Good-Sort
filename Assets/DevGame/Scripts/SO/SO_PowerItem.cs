using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct DataPowerItem
{
    public PowerupKind kind;
    public int price;
    public int LevelShow;
    public string textDes;
}

[CreateAssetMenu(fileName = "SO_PowerItem", menuName = "ScriptableObjects/SO_PowerItem", order = 2)]
public class SO_PowerItem : ScriptableObject
{
    public List<DataPowerItem> dataPowerItems;

    public DataPowerItem GetDataPowerItem(PowerupKind kind)
    {
        foreach(var da in dataPowerItems)
        {
            if(da.kind == kind)
            {
                return da;
            }
        }
        return new();
    }
}
