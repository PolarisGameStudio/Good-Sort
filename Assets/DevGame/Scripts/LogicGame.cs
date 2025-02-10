using GoodSortEditor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LogicGame : Singleton<LogicGame>
{
    public GameObject objSelll;
    public GameObject PrefabCellLock;

    public Transform PTop;
    public Transform PBot;

    private List<Cell> listCellLock = new();
    int _currentLock = 0;


    int _numCellLock = 0;
    int _numCellHiden = 0;

    void Start()
    {
        OnLoadLevel();
    }

    public static Vector2 GetSizeCameraInWord()
    {
        Camera mainCamera = Camera.main;
        var height = mainCamera.orthographicSize * 2;
        var width = (float)Screen.width / (float)Screen.height * height;
        return new Vector2(width, height);
    }

    public void OnLoadLevel()
    {
        var level = GenLevelController.Instance.GetDataLevel();

        var time = level.timeToPlay;
        _numCellLock = level.numberCellLock;
        _numCellHiden = level.itemHiden;
        var cell = level.cells;

        var sizeCamera = GetSizeCameraInWord();

        sizeCamera.x -= 0.75f;

        int col = (int)Math.Sqrt((int)cell.Count);

        int row = cell.Count / col;

        if (cell.Count % col != 0)
        {
            row++;
        }

        float xAdd = 3.5f;
        float yAdd = 2.5f;

        float xAdd1 = 0;
        float yAdd1 = 0;

        yAdd1 = yAdd / 2;
        xAdd1 = xAdd / 2.0f;

        var totalX = col * xAdd;
        var totalY = row * yAdd;
        float scale = 1;

        var distanceY = Vector2.Distance(PTop.position, PBot.position) - 0.75f;

        if (totalX > sizeCamera.x || totalY > distanceY)
        {
            var sx = sizeCamera.x / totalX;
            var sy = distanceY / totalY;
            scale = Math.Min(sx, sy);
        }

        var vecbegin = new Vector2(-xAdd * col / 2.0f * scale + xAdd1 * scale, PTop.position.y / 2 + PBot.position.y / 2 - yAdd * row / 2.0f * scale + yAdd1 * scale);
        int index = 0;
        List<GameObject> objBox = new();


        var grid = Create2DArray(cell);
        int kk = 0;

        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);


        int indexX = -1;

        for (int i = 0; i < rows; i++)
        {
            bool isAdd = false;
            int indexj = 0;
            for (int j = 0; j < cols; j++)
            {
                if(grid[i, j] == null)
                {
                    continue;
                }

                if(!isAdd)
                {
                    isAdd = true;
                    indexX++;
                }

                var prefab = GenLevelController.Instance.GetPrefabCell(grid[i, j].cellType);

                if(prefab == null)
                {
                    continue;
                }

                indexj++;

                var obj = Instantiate(prefab.prefab.gameObject);
              //  obj.transform.localScale = Vector3.one * scale;
                obj.transform.position = new Vector2((grid[i, j].posX + 3.0f), grid[i,j].posY - 1.5f * 0);


                float xNew = obj.transform.position.x;


                float k = 2f;

                if (xNew < 0)
                {
                    if(grid[i, j].posX % 2 == 0)
                    {
                        xNew += k;
                    }
                    else
                    {
                        xNew += 2.5f;
                    }
                }

                if (xNew > 0)
                {
                    if (grid[i, j].posX % 2 == 0)
                    {
                        xNew -= k;
                    }
                    else
                    {
                        xNew -= 2.5f;
                    }
                }

                float YNew = obj.transform.position.y;

              //  obj.transform.position = new Vector3(xNew, YNew);



                obj.name = grid[i, j].posX.ToString() + "," + grid[i, j].posY.ToString();
                index++;
                objBox.Add(obj);
            }
        }

        index = 0;

        bool IsLock = false;

        List<Cell> listCells = new();

        foreach (var it in cell)
        {
            var obj = objBox[index];
            index++;
            var ScCell = obj.GetComponent<Cell>();
            ScCell.SetData(it.itemsLayer, it.cellType);
            listCells.Add(ScCell);

            if (it.isLock > 0)
            {
                IsLock = true;
                ScCell.OnLockCell(PrefabCellLock);
                listCellLock.Add(ScCell);
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

        if (_numCellLock > 0 && !IsLock)
        {
            for(int i = 0; i < _numCellLock; i++)
            {
                var numRand = UnityEngine.Random.Range(0, listCells.Count - 1);
                var cellLock = listCells[numRand];
                listCells.Remove(cellLock);
                cellLock.OnLockCell(PrefabCellLock);
                listCellLock.Add(cellLock);
            }
        }


    }

    CellInfo[,] Create2DArray(List<CellInfo> objects)
    {
        List<int> uniqueX = objects.Select(o => o.posX).Distinct().OrderBy(x => x).ToList();
        List<int> uniqueY = objects.Select(o => o.posY).Distinct().OrderBy(y => y).ToList();

        int rows = uniqueY.Count;
        int cols = uniqueX.Count;

        CellInfo[,] grid = new CellInfo[rows, cols];

        
        foreach (var obj in objects)
        {
            int xIndex = uniqueX.IndexOf(obj.posX);
            int yIndex = uniqueY.IndexOf(obj.posY);
            grid[yIndex, xIndex] = obj;
        }

        return grid;
    }

    public void CheckObjectLock()
    {
        if(listCellLock.Count > 0)
        {
            var currentLock = listCellLock[0];
            _currentLock++;

            currentLock.OnUpdateNumLock(_currentLock);

            if (_currentLock == 4)
            {
                _currentLock = 0;
                listCellLock.Remove(currentLock);
                currentLock.UnLockCellAllItem();
            }
        }
    }

    void Shuffle<T>(List<T> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int randomIndex = UnityEngine.Random.Range(0, i + 1);
            T temp = list[i];
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }

}
