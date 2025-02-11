using GoodSortEditor;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

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

    public Transform p1 = null;
    public Transform p2 = null;
    public Transform p3 = null;
    Vector2 sizeCamera = Vector2.zero;


    void Start()
    {
        sizeCamera = GetSizeCameraInWord();
        OnLoadLevel();
    }

    public static Vector2 GetSizeCameraInWord()
    {
        Camera mainCamera = Camera.main;
        var height = mainCamera.orthographicSize * 2;
        var width = (float)Screen.width / (float)Screen.height * height;
        return new Vector2(width, height);
    }

    public void OnNextLevel()
    {
        StartCoroutine(LoadData());
    }    

    IEnumerator LoadData()
    {
        p2.transform.position = Vector3.zero;
        p2.transform.localScale = Vector2.one;
        for (int i = 0; i < p2.childCount; i++)
        {
            Destroy(p2.GetChild(i).gameObject);
        }
        yield return new WaitForSeconds(0.25f);
        p2.transform.position = Vector3.zero;
        p2.transform.localScale = Vector2.one;
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();

        OnLoadLevel();
    }

    public void OnLoadLevel()
    {

        var level = GenLevelController.Instance.GetDataLevel();

        var time = level.timeToPlay;
        _numCellLock = level.numberCellLock;
        _numCellHiden = level.itemHiden;
        var cell = level.cells;


        sizeCamera.x -= 0.75f;

        int col = (int)Math.Sqrt((int)cell.Count);

        int row = cell.Count / col;

        if (cell.Count % col != 0)
        {
            row++;
        }

        float xAdd = 3.6f;
        float yAdd = 2.5f;

        float xAdd1 = 0;
        float yAdd1 = 0;

        yAdd1 = yAdd / 2;
        xAdd1 = xAdd / 2.0f;

        var totalX = col * xAdd;
        var totalY = row * yAdd;
        float scale = 1;

        var distanceY = Vector2.Distance(PTop.position, PBot.position) - 0.75f;

        scale = 1;

        var vecbegin = new Vector2(-xAdd * col / 2.0f * scale + xAdd1 * scale, PTop.position.y / 2 + PBot.position.y / 2 - yAdd * row / 2.0f * scale + yAdd1 * scale);

        vecbegin = new Vector2(-15, -16);
        var vecbegin1 = new Vector2(-15, -15);


        int index = 0;


        int indexX = -1;

        float XMin = 99999, yMin = 99999;
        float XMax = -99999, yMax = -99999;

        foreach(var ce in cell)
        {
            if(ce.cellType == 0)
            {
                XMin = Math.Min(XMin, (float)ce.posX);
                XMax = Math.Max(XMax, (float)ce.posX);

                yMin = Math.Min(yMin, (float)ce.posY);
                yMax = Math.Max(yMax, (float)ce.posY);
            }    
        }

        float xtt = Math.Abs(XMin) / 2 + Math.Abs(XMax) / 2;
        float ytt = Math.Abs(yMin) / 2 + Math.Abs(yMax) / 2;

        var disX = xtt * 2;
        var disY = ytt * 2;

    
        index = 0;

        bool IsLock = false;

        List<Cell> listCells = new();

        List<Cell> objCellPoint = new();

        foreach (var it in cell)
        {
            var prefab = GenLevelController.Instance.GetPrefabCell(it.cellType);
            var obj = Instantiate(prefab.prefab.gameObject, p2);
            var ScCell = obj.GetComponent<Cell>();
            ScCell.SetData(it.itemsLayer, it.cellType, it.moveType);
            objCellPoint.Add(ScCell);

            if (it.cellType == 0 || it.cellType == 3)
            {
                listCells.Add(ScCell);
            }

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


            var disX1 = Math.Abs(it.posX - XMin);
            var disY2 = Math.Abs(it.posY - yMin);

            if(it.cellType == 1)
            {
                //it.posX -= 4;
            }

            float XNew = it.posX;
            float YNew = it.posY;

            float Xaaa1 = 0;

            if(it.cellType == 0)
            {
                Xaaa1 = 3.6f;
            }

            if (it.cellType == 1)
            {
                Xaaa1 = 1.4f;
            }

            if (it.cellType == 2)
            {
                Xaaa1 = 1.4f;
            }

            if (disX1 != 0)
            {
                if ((int)disX1 - disX1 < 0.1f)
                {
                    float pd = disX1 / 6.0f;
                    if (XMin < it.posX)
                    {
                        XNew = XMin - pd * 3.6f;
                    }
                    else
                    {
                        XNew = XMin + pd * 3.6f;
                    }

                }
            }

            if (disY2 != 0)
            {
                if ((int)disY2 - disY2 < 0.1f)
                {
                    float pd = disY2 / 4.0f;

                    if(yMin < it.posY)
                    {
                        YNew = yMin - pd * 2.5f;
                    }
                    else
                    {
                        YNew = yMin + pd * 2.5f;
                    }
                }
            }
            if(it.cellType == 2)
            {
                XNew = XNew + 1.2f;
            }

            if(it.cellType == 1)
            {
                XNew = XNew + 1.2f;
            }

            obj.transform.position = new Vector2(XNew, YNew);

            obj.name = it.posX.ToString() + "," + it.posY.ToString();


            Debug.Log("cmmmm_cmmm_" + disX1 + "_" + disY2);
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


        if (disX > sizeCamera.x || disY > distanceY)
        {
            var sx = sizeCamera.x / disX;
            var sy = distanceY / disY;
            scale = Math.Min(sx, sy);
        }

        ResetPoint(objCellPoint);

        //foreach (var it in objBox)
        {
          //  it.transform.localPosition = it.transform.localPosition + new Vector3(Math.Abs(xtt), Math.Abs(ytt), 0);
        }

       // p2.localScale = Vector3.one * scale;
    }

    void ResetPoint(List<Cell> listCell)
    {
        float XMin = 99999, yMin = 99999;
        float XMax = -99999, yMax = -99999;
        bool isIdle = true;
        var newCell = listCell.Where(x=>(x.CellType == CellType.CellNormal || x.CellType == CellType.CellLayerCount) && x.MoveType == MoveType.Idle).Distinct().OrderBy(x=>x.transform.position.y).ToList();
        if(newCell.Count == 0)
        {
            isIdle = false;
            newCell = listCell.Distinct().OrderBy(x => x.transform.position.y).ToList();
        }

        foreach(var it in listCell)
        {
            XMin = Mathf.Min(XMin, it.transform.position.x);
            XMax = Mathf.Max(XMax, it.transform.position.x);

            yMin = Mathf.Min(yMin, it.transform.position.y);
            yMax = Mathf.Max(yMax, it.transform.position.y);
        }

        float xtt = Mathf.Abs(XMin) / 2 + Mathf.Abs(XMax) / 2;
        float ytt = Math.Abs(yMin) / 2 + Mathf.Abs(yMax) / 2;

        float poinXMid = XMin + XMax;

        poinXMid = poinXMid > 0 ? -xtt : xtt;

        var disPTopBot = PTop.transform.position.y - PBot.transform.position.y;
        var disY = yMin - yMax;

        if( Math.Abs(Math.Abs(disY) - Math.Abs(disPTopBot)) < 5.0f)
        {
            newCell = listCell.Distinct().OrderBy(x => x.transform.position.y).ToList(); ;
            isIdle = true;
        }

        if (isIdle)
        {
            yMin = 99999; yMax = -99999;

            var pyMid = PTop.transform.position.y / 2 + PBot.transform.position.y / 2;

            foreach (var it in newCell)
            {
                

                yMin = Mathf.Min(yMin, it.transform.position.y);
                yMax = Mathf.Max(yMax, it.transform.position.y);
            }

            XMax = -99999; XMin = 99999;

            var newCell1 = listCell.Where(x => x.CellType == CellType.CellNormal || x.CellType == CellType.CellLayerCount && x.MoveType == MoveType.Idle).Distinct().OrderBy(x => x.transform.position.y).ToList();
            if(newCell1.Count > 0)
            {
                foreach (var it in newCell1)
                {
                    XMin = Mathf.Min(XMin, it.transform.position.x);
                    XMax = Mathf.Max(XMax, it.transform.position.x);
                }
            }


            float disYMaxMin = yMax - yMin;
            float disXMaxMin = XMax - XMin;

            float yM = (yMin + yMax) / 2;
            float yMM = pyMid - yM;

            ytt = yM > pyMid ? - Math.Abs(yMM) : Math.Abs(yMM);

            foreach (var it in listCell)
            {
                //  it.transform.localPosition = it.transform.localPosition + new Vector3(Math.Abs(xtt), Math.Abs(ytt), 0);
                it.transform.position = it.transform.position + new Vector3(poinXMid, ytt, 0);
            }
            p2.transform.position = new Vector2(0, pyMid);


            float distanceX = 3.6f;
            float distanceY = 2.4f;

            float scale = 1;

            if(disYMaxMin > disPTopBot - distanceY || disXMaxMin > sizeCamera.x - distanceX)
            {
                var sx = (sizeCamera.x - distanceX) / disXMaxMin;
                var sy = (disPTopBot - distanceY) / disYMaxMin;
                scale = Math.Min(sx, sy);
                p2.transform.localScale = Vector2.one * scale;
            }
        }
        else
        {
            var pmin = newCell[0].transform.position;
            var vecAdd = Vector3.zero - pmin;
            var yAddd = vecAdd.y > PBot.transform.position.y ? PBot.transform.position.y + 1.4f : -PBot.transform.position.y - 1.4f;
            var pxBegin = PBot.transform.position.y;

            foreach (var cell in listCell)
            {
                cell.transform.position += new Vector3(poinXMid, vecAdd.y + yAddd);
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
