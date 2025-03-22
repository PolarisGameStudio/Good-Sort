using Newtonsoft.Json;
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

public class SOItemContainer : Singleton<SOItemContainer>
{
	List<DataSoItemItemAsset> dataSoItemItemAssets = new();

	private Dictionary<ItemType, ItemAsset> _dicItem = new();

    private Dictionary<int, string> _dictNameSpr = new();

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

        for(int i = 1; i <= 100; i++)
        {
            _dictNameSpr.Add(i, "AS_" + i.ToString());
        }    
    }


    ItemAsset GetSoItemItemAsset(DataSoItemItemAsset item)
    {
        ItemAsset da = new();
        da.type = item.type;



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


        int minKey = _dictNameSpr.Keys.Min();
        var sprite = _dictNameSpr[minKey];
        _dictNameSpr.Remove(minKey);

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
