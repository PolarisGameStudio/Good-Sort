
using System;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using static UnityEditor.Progress;


public class GenLevelController : Singleton<GenLevelController>
{
	[Serializable]
	public class BoardSize
	{
		public int minX;

		public int maxX;

		public int minY;

		public int maxY;
	}

	[Serializable]
	public class ItemHalloween
	{
		public Sprite item;

		public Sprite itemHidden;
	}

	[HideInInspector]
	public BoardSize boardSizeForCam;

	[HideInInspector]
	public BoardSize boardSize;

	[SerializeField]
	private string _level;


	[SerializeField]
	private SOCell _soCells;

/*	[SerializeField]
	private SOItem _soCells11;*/

	public Dictionary<int, ItemAssetSeasonal> DicItemSeasonal;

	private LevelInfo _levelInfoInit;

	protected LevelInfo _levelInfo;

	public List<int> itemHidens;

	private int _totalItem;

	private int max_level;

	private int currentLevelPlaying;

	public SOLevel currentSOLevel;

	private bool _usingLevelSO;

	private bool isLevelDrop;

	public Dictionary<Vector2Int, CellType?> cellTypeByPos;

	public int LevelId = 0;

    public LevelInfo LevelInfoInit => null;

	public int TotalItem => 0;

	public LevelInfo GetDataLevel()
	{

/*		List<DataSoItemItemAsset> dass = new();

		foreach(var so in _soCells11.items)
		{
			DataSoItemItemAsset da = new();
			da.type = so.type;
			da.sprite = so.sprite.name;
			if(so.spriteHidden != null)
			{
                da.spriteHidden = so.spriteHidden.name;
            }
            da.kind = so.kind;
            da.colors = so.colors;
			dass.Add(da);
        }

		var txx = JsonConvert.SerializeObject(dass);*/

/*		foreach(var it in _soCells11.items)
		{
			if(it.spriteHidden != null)
			{
                var tx = it.spriteHidden.name;
                var txtture = Resources.Load<Sprite>("Texture2D/ImageHide/" + tx);
                if (txtture != null)
                {
                    it.spriteHidden = txtture;
                }
            }
			
		}

		_soCells11.SaveToFile();*/

        LevelId = HelperManager.DataPlayer.LevelID;
		HelperManager.DataPlayer.LevelID++;

        var txt = Resources.Load<TextAsset>("Json/da_level");
        var levels = JsonConvert.DeserializeObject<List<string>>(txt.text);
		//132
        var nameLevel = levels[158];
        var Level1 = Resources.Load<SOLevel>("Data/Level/" + nameLevel);

        //19
        return Level1.level;
	}

    private void Start()
    {
    }

	public CellAsset GetPrefabCell(int type)
	{
		var asset = _soCells.GetCellAsset((CellType) type);
		return asset;
    }
}

