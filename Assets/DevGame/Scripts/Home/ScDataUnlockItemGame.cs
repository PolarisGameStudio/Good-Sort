using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScDataUnlockItemGame : MonoBehaviour
{
    public List<DataUseItem> dataUseItems = new();

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
            dataUseItems.Clear();
            dataUseItems = JsonConvert.DeserializeObject<List<DataUseItem>>(textAset);
        }

        for (int i = 0; i < dataUseItems.Count; i++)
        {
            var da = dataUseItems[i];
            if (HelperManager.DataPlayer.LevelID >= da.LevelMin && HelperManager.DataPlayer.LevelID <= da.LevelMax)
            {
                return da;
            }
        }
        return null;
    }
}
