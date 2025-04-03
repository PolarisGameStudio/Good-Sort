using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScDataUnlockItemGame : MonoBehaviour
{
    public List<DataUseItem> dataUseItems = new();

    public List<DataUseItem> dataUseItems1 = new();

    public static ScDataUnlockItemGame instance = null;
    public List<Sprite> listSpr = new();

    string textAset = "";

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
    }

    public Sprite GetSpriteCategory()
    {
        return listSpr[HelperManager.DataPlayer.LevelID % listSpr.Count];
    }
  
    public DataUseItem GetDataUseItem()
    {
        for (int i = 0; i < dataUseItems.Count; i++)
        {
            if (HelperManager.DataPlayer.LevelID >= dataUseItems[i].LevelMin && HelperManager.DataPlayer.LevelID <= dataUseItems[i].LevelMax)
            {
                return dataUseItems[i];
            }
        }

        if (string.IsNullOrEmpty(textAset))
        {
            textAset = Resources.Load<TextAsset>("Json/DataUnlockItem").text;
            dataUseItems1 = JsonConvert.DeserializeObject<List<DataUseItem>>(textAset);
        }

        for (int i = 0; i < dataUseItems1.Count; i++)
        {
            var da = dataUseItems1[i];
            if (HelperManager.DataPlayer.LevelID >= da.LevelMin && HelperManager.DataPlayer.LevelID <= da.LevelMax)
            {
                return da;
            }
        }
        return null;
    }

    public DataUseItem GetDataUseItemByLevel()
    {
        var levelId = HelperManager.DataPlayer.LevelID;

        int index = 0;

        for (int i = 0; i < dataUseItems.Count; i++)
        {
            if (levelId >= dataUseItems[i].LevelMin && levelId <= dataUseItems[i].LevelMax)
            {
                index = i;
                break;
            }
        }

        if(dataUseItems.Count > 0 && index - 1 < dataUseItems.Count && index != 0)
        {
            return dataUseItems[index - 1];
        }


        if (string.IsNullOrEmpty(textAset))
        {
            textAset = Resources.Load<TextAsset>("Json/DataUnlockItem").text;
            dataUseItems1.Clear();
            dataUseItems1 = JsonConvert.DeserializeObject<List<DataUseItem>>(textAset);
        }

        int index1 = -1;

        for (int i = 0; i < dataUseItems1.Count; i++)
        {
            var da = dataUseItems1[i];
            if (levelId >= da.LevelMin && levelId <= da.LevelMax)
            {
                index1 = i;
                break;
            }
        }

        if(index1 == -1)
        {
            return dataUseItems[0];
        }

        if (index1 == 0)
        {
            return dataUseItems[1];
        }

        if (dataUseItems1.Count > 0 && index1 - 1 < dataUseItems1.Count && index1 != 0)
        {
            return dataUseItems1[index1 - 1];
        }

        return dataUseItems[0]; ;
    }
}
