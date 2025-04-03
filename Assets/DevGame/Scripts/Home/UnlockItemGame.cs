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

    void Start()
    {

    }

    public void UpdateUi(DataUseItem daUse)
    {
        if(daUse.sprCategory == null)
        {
            daUse.sprCategory = ScDataUnlockItemGame.instance.GetSpriteCategory();
        }

        imgCategory.sprite = daUse.sprCategory;
        imgCategory.SetNativeSize();
        for (int i = 0; i < listImageItems.Count; i++)
        {
            var spr = Resources.Load<Sprite>("Texture2D/newImage/AS_" + daUse.NameItemRemove[i].ToString());
            listImageItems[i].sprite = spr;
            listImageItems[i].SetNativeSize();
        }
    }    

}
