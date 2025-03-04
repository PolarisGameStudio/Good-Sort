using Newtonsoft.Json;
using System.Collections.Generic;
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

	protected override void Awake()
	{
        var txt = Resources.Load<TextAsset>("Json/da_SoItemItemAsset");
        dataSoItemItemAssets = JsonConvert.DeserializeObject<List<DataSoItemItemAsset>>(txt.text);
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
                da.type = item.type;
				da.sprite = Resources.Load<Sprite>("Texture2D/" + item.sprite);
				da.spriteHidden = Resources.Load<Sprite>("Texture2D/" + item.spriteHidden);
				da.kind = item.kind;
				da.colors = item.colors;
            }
		}

		_dicItem.Add(itemType, da);


        return da;
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
