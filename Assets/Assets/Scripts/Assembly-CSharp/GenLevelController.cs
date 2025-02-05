using System;
using System.Collections.Generic;
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

	public GameObject objSelll;

	public Transform PTop;
	public Transform PBot;


    public static Vector2 GetSizeCameraInWord()
    {
        Camera mainCamera = Camera.main;
        var height = mainCamera.orthographicSize * 2;
        var width = (float)Screen.width / (float)Screen.height * height;
        return new Vector2(width, height);
    }

    protected override void Awake()
	{
		var level = _levelData.listLevels[1].sOLevels[0].level;

		var time = level.timeToPlay;
		var numLock = level.numberCellLock;
		var itemHiden = level.itemHiden;
		var cell = level.cells;

		var sizeCamera = GetSizeCameraInWord();

		sizeCamera.x -= 0.75f;


        Debug.Log("cmmm: " + sizeCamera);
		int col = 3;

		int row = cell.Count / 3;
		
		if(cell.Count % 3 != 0)
		{
			row++;
		}

        float xAdd = 3.5f;
        float yAdd = 2.5f;

        float xAdd1 = 0;
		float yAdd1 = 0;

		col = 4;
		row = 4;

		//if(row %2 == 0)
		{
			yAdd1 = yAdd / 2;

        }

       // if (col % 2 != 0)
        {
			xAdd1 = xAdd / 2.0f;
        }

        var totalX = col * xAdd;
		var totalY = row * yAdd;
		float scale = 1;

		if(totalX > sizeCamera.x || totalY > sizeCamera.y)
		{
            var sx = sizeCamera.x / totalX;
			var sy = sizeCamera.y / totalY;
			scale = Math.Min(sx, sy);
        }

        var vecbegin = new Vector2( -xAdd * col / 2.0f * scale + xAdd1 * scale, PTop.position.y / 2 + PBot.position.y / 2 - yAdd * row / 2.0f * scale + yAdd1 * scale);
        int index = 0;
		List<GameObject> objBox = new();

		for(int i = 0; i < row; i++)
		{
			for(int j = 0; j < col; j++)
			{
				if (index >= cell.Count)
				{
					break;
				}
				var obj = Instantiate(objSelll);
                obj.transform.localScale = Vector3.one * scale;
                obj.transform.position = vecbegin + new Vector2(xAdd * j * scale, yAdd * i * scale);
				obj.name = i.ToString() + "," + j.ToString();
                index++;
                objBox.Add(obj);
            }
		}

		index = 0;

        foreach (var it in cell)
		{
			var obj = objBox[index];
			index++;
            var ScCell = obj.GetComponent<Cell>();
			ScCell.SetData(it.itemsLayer);

            foreach (var ly in it.itemsLayer)
			{
				string cc1 = "(";
				for(int i = 0; i < ly.items.Count; i++)
				{
                    cc1 += ly.items[i] + ",";
                }
                cc1 += "),";
                Debug.Log(cc1);
            }
        }

    }
}
