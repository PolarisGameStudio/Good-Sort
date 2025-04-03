using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class DataUnlockItem
{
    public int LevelMin = 0;
    public int levelMax = 0;
    public List<int> NameItemRemove = new();
}

public class UnlockItemGame : MonoBehaviour
{
    [SerializeField] Image imgCategory;
    [SerializeField] List<Image> listImageItems = new();

    List<int> check(List<int> listDa)
    {
        if (listDa.Count <= 0)
        {
            for (int i = 0; i < 100; i++)
            {
                listDa.Add(i);
            }
        }

        HelperManager.Shuffle(listDa);
        return listDa;
    }

    void Start()
    {
        List<int> listDa = new();

        for (int i = 1; i <= 100; i++)
        {
            listDa.Add(i);
        }

        List<DataUnlockItem> dataUnlocks = new();

        int levelBegin = 10;

        while (levelBegin < 2100)
        {
            DataUnlockItem da = new();
            da.LevelMin = levelBegin;
            da.levelMax = levelBegin + 4;
            levelBegin += 5;

            for (int i = 0; i < 3; i++)
            {
                listDa = check(listDa);
                var ind = listDa[0];
                listDa.RemoveAt(0);
                da.NameItemRemove.Add(ind);
            }

            dataUnlocks.Add(da);
        }

        var text = JsonConvert.SerializeObject(dataUnlocks);

        DataUseItem daUse = null;
        for (int i = 0; i < ScDataUnlockItemGame.instance.dataUseItems.Count; i++)
        {
            var da = ScDataUnlockItemGame.instance.dataUseItems[i];
            if (HelperManager.DataPlayer.LevelID >= da.LevelMin && HelperManager.DataPlayer.LevelID <= da.LevelMax)
            { 
                daUse = da;
                break;
            }
        }

        if(daUse != null)
        {
            imgCategory.sprite = daUse.sprCategory;
            imgCategory.SetNativeSize();
            for (int i = 0; i < listImageItems.Count; i++)
            {
                var spr = Resources.Load<Sprite>("Texture2D/newImage/AS_" + daUse.NameItemRemove[i].ToString());
                listImageItems[i].sprite = spr;
                listImageItems[i].SetNativeSize();
            }
            return;
        }

        daUse = ScDataUnlockItemGame.instance.GetDataUseItem();

        if(daUse == null)
        {
            return;
        }

        imgCategory.sprite = ScDataUnlockItemGame.instance.GetSpriteCategory();
        imgCategory.SetNativeSize();
        for (int i = 0; i < listImageItems.Count; i++)
        {
            var spr = Resources.Load<Sprite>("Texture2D/newImage/AS_" + daUse.NameItemRemove[i].ToString());
            listImageItems[i].sprite = spr;
            listImageItems[i].SetNativeSize();
        }
    }





}
