
using System;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;


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
		LevelId = HelperManager.DataPlayer.LevelID;

        var txt = Resources.Load<TextAsset>("Json/da_level");
        var levels = JsonConvert.DeserializeObject<List<string>>(txt.text);

        var nameLevel = levels[LevelId];
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

