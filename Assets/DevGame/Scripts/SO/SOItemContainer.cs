using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class DataSoItemItemAsset
{
    public ItemType type;

    public string sprite;

    public string spriteHidden;

    public ItemKind kind;

    public ItemColor[] colors;
}

[Serializable]
public class DataUseItem
{
    public int LevelMin = 0;
    public int LevelMax = 0;

    public int ItemMin = 0;
    public int ItemMax = 0;

    public List<int> NameItemRemove = null;

    public Sprite sprCategory;
}

public class SOItemContainer : Singleton<SOItemContainer>
{
	List<DataSoItemItemAsset> dataSoItemItemAssets = new();

	private Dictionary<ItemType, ItemAsset> _dicItem = new();

    private Dictionary<int, string> _dictNameSpr = new();

    private Dictionary<int, string> _dictNameSprItemUse = new();

	protected override void Awake()
	{
        var txt = Resources.Load<TextAsset>("Json/da_SoItemItemAsset");
        dataSoItemItemAssets = JsonConvert.DeserializeObject<List<DataSoItemItemAsset>>(txt.text);

        foreach(var it in dataSoItemItemAssets)
        {
            if(it.spriteHidden == it.sprite)
            {
                Debug.Log("cmmmm132: " + it.type);
            }
        }

        AddDictName();
       // _dictNameSpr = _dictNameSpr.OrderBy(x=>x.Key).ToDictionary(x => x.Key, x => x.Value);
    }

    private void AddDictName()
    {
        _dictNameSpr.Clear();

        if(ScDataUnlockItemGame.instance != null)
        {
            int index = 0;

            for (int i = 0; i < ScDataUnlockItemGame.instance.dataUseItems.Count; i++)
            {
                var da = ScDataUnlockItemGame.instance.dataUseItems[i];
                if (HelperManager.DataPlayer.LevelID >= da.LevelMin && HelperManager.DataPlayer.LevelID <= da.LevelMax)
                {
                    for (int it = da.ItemMin; it <= da.ItemMax; it++)
                    {
                        if (da.NameItemRemove.Contains(it))
                        {
                            continue;
                        }
                        _dictNameSpr.Add(it, "AS_" + it.ToString());
                    }
                    index = i;
                    break;
                }
            }

            if (_dictNameSpr.Count > 0)
            {
                for (int i = 0; i < index; i++)
                {
                    foreach (var it in ScDataUnlockItemGame.instance.dataUseItems[i].NameItemRemove)
                    {
                        _dictNameSprItemUse.Add(it, "AS_" + it.ToString());
                    }
                }

                return;
            }

            var daUse = ScDataUnlockItemGame.instance.GetDataUseItem();

            List<int> list1 = new();
            for (int i = 1; i <= 100; i++)
            {
                list1.Add(i);
            }

            HelperManager.Shuffle(list1);

            foreach (var it in list1)
            {
                bool isBreak = false;
                foreach(var iti in daUse.NameItemRemove)
                {
                    if(it == iti)
                    {
                        isBreak = true;
                        continue;
                    }
                }

                if(isBreak)
                {
                    continue;
                }

                _dictNameSpr.Add(it, "AS_" + it.ToString());
            }

        }    

        List<int> list = new();
        for (int i = 1; i <= 100; i++)
        {
            list.Add(i);
        }

        HelperManager.Shuffle(list);

        foreach (var it in list)
        {
            _dictNameSpr.Add(it, "AS_" + it.ToString());
        }

    }


    public void OnAdd()
    {
        _dicItem.Clear();
        _dictNameSpr.Clear();
        for (int i = 1; i <= 100; i++)
        {
            _dictNameSpr.Add(i, "AS_" + i.ToString());
        }
        //_dictNameSpr = _dictNameSpr.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

    }


    ItemAsset GetSoItemItemAsset(DataSoItemItemAsset item)
    {
        ItemAsset da = new();
        da.type = item.type;
        da.daIt = item;



        /*  if(item.sprite == item.spriteHidden)
          {
              da.sprite = Resources.Load<Sprite>("Texture2D/ImageHide/" + item.sprite);
              if (da.sprite == null)
              {
                  da.sprite = Resources.Load<Sprite>("Texture2D/" + item.sprite);
              }
          }
          else
          {
              da.sprite = Resources.Load<Sprite>("Texture2D/" + item.sprite);
          }

          if (da.sprite == null)
          {
              da.sprite = Resources.Load<Sprite>("Texture2D/ImageHide/" + item.sprite);
          }
          da.spriteHidden = Resources.Load<Sprite>("Texture2D/ImageHide/" + item.spriteHidden);
          if (da.spriteHidden == null)
          {
              da.spriteHidden = Resources.Load<Sprite>("Texture2D/" + item.spriteHidden);
          }*/

        string sprite = "";

        if(_dictNameSprItemUse.Count > 0 && UnityEngine.Random.Range(1, 100) % 3 == 0)
        {
            int key = _dictNameSprItemUse.Keys.PickRandom();
            sprite = _dictNameSprItemUse[key];
            _dictNameSprItemUse.Remove(key);
        }
        else
        {
            int minKey = _dictNameSpr.Keys.PickRandom();
            sprite = _dictNameSpr[minKey];
            _dictNameSpr.Remove(minKey);
        }

        da.spriteHidden = Resources.Load<Sprite>("Texture2D/newImage/" + sprite);

        if (da.spriteHidden == null)
        {
            da.spriteHidden = Resources.Load<Sprite>("Texture2D/" + item.spriteHidden);
            da.sprite = Resources.Load<Sprite>("Texture2D/" + item.sprite);
        }
        else
        {
            da.sprite = Resources.Load<Sprite>("Texture2D/newImage/" + sprite);
        }

        da.kind = item.kind;
        da.colors = item.colors;
        return da;
    }

    public ItemAsset GetItemAsset(ItemType itemType)
	{
        if (_dicItem.ContainsKey(itemType))
		{
			return _dicItem[itemType];
		}

        ItemAsset da = new();

        foreach (var item in dataSoItemItemAssets)
		{
			if(item.type == itemType)
			{
                da = GetSoItemItemAsset(item);
                break;
            }
		}

		_dicItem.Add(itemType, da);

        return da;
	}

	public ItemAsset GetItemAsset(string nameItemHide)
	{
        foreach (var item in dataSoItemItemAssets)
        {
            if (item.spriteHidden == nameItemHide && item.spriteHidden != item.sprite)
            {
                if (_dicItem.ContainsKey(item.type))
                {
                    return _dicItem[item.type];
                }

                ItemAsset da = GetSoItemItemAsset(item); ;
                _dicItem.Add(item.type, da);
                return da;
            }
        }

        foreach (var item in dataSoItemItemAssets)
        {
            if (item.spriteHidden == nameItemHide)
            {
                if (_dicItem.ContainsKey(item.type))
                {
                    return _dicItem[item.type];
                }
                ItemAsset da = GetSoItemItemAsset(item); ;
                _dicItem.Add(item.type, da);
                return da;
            }
        }

        return null;
    }	

	public ItemAsset GetItemAsset(int itemType)
	{
		return GetItemAsset((ItemType) itemType);
	}

	public SOItemSeasonal GetSOItemSeasonal()
	{
		return null;
	}
}
