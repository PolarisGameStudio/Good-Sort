using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerItem : MonoBehaviour
{
    public List<Item> listItem = new() { null, null, null};
    public List<Vector3> listPoint = new() { new Vector3(-1, 0, 0), new Vector3(0, 0, 0), new Vector3(1, 0, 0)};

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

}
