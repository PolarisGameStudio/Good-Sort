using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct DataBoosterItem
{
    public BoosterKind kind;
    public int LevelShow;
    public int price;
    public string textDes;
}

[CreateAssetMenu(fileName = "SO_Booster", menuName = "ScriptableObjects/SO_Booster", order = 2)]
public class SO_Booster : ScriptableObject
{
    public List<DataBoosterItem> dataBoosterItems;

    public DataBoosterItem GetDataPowerItem(BoosterKind kind)
    {
        foreach (var da in dataBoosterItems)
        {
            if (da.kind == kind)
            {
                return da;
            }
        }
        return new();
    }
}
