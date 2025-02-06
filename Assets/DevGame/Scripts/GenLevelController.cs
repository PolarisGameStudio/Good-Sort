using GoodSortEditor;
using System;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

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
	private SOLevelData _levelData;

	[SerializeField]
	private SOLevelData _levelDataAbTest;

	[SerializeField]
	private SOLevelData _levelDataIOS;

	[SerializeField]
	private LevelController _levelController;

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


	public LevelInfo LevelInfoInit => null;

	public int TotalItem => 0;

	public LevelInfo GetDataLevel()
	{
		return _levelData.listLevels[6].sOLevels[0].level;
	}


    private void Start()
    {
		int index = 0;
		foreach (var it1 in _levelData.listLevels)
		{
			string Leve1l = "Level_" + index.ToString() + "_";
			index++;

            var infoLevel = it1.sOLevels[0].level;

            foreach (var it in infoLevel.cells)
            {
				if(it.cellType > 0)
				{
					Leve1l += it.cellType.ToString() + "_";
                }

                foreach (var ly in it.itemsLayer)
                {
                    string cc1 = "(";
                    for (int i = 0; i < ly.items.Count; i++)
                    {
                        cc1 += ly.items[i] + ",";
                    }
                    cc1 += "),";
                    Debug.Log(cc1);
                }
            }

			Debug.Log(Leve1l);
        }
    }

	public CellAsset GetPrefabCell(int type)
	{
		var asset = _soCells.GetCellAsset((CellType) type);
		return asset;
    }
}

