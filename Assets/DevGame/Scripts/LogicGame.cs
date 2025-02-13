using Coffee.UIExtensions;
using DG.Tweening;
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
    List<List<Cell>> ListCellDrop = new();

    public UIParticle uiAnimStarCombo = null;

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


        bool IsLock = false;

        List<Cell> listCells = new();

        List<Cell> objCellPoint = new();

        foreach (var it in cell)
        {
            var prefab = GenLevelController.Instance.GetPrefabCell(it.cellType);
            var obj = Instantiate(prefab.prefab.gameObject, p2);
            var ScCell = obj.GetComponent<Cell>();
            ScCell.SetData(it.itemsLayer, it.cellType, it.moveType, new Vector2Int(it.posX, it.posY), it.speed);
            objCellPoint.Add(ScCell);
            if(ScCell.txtName != null)
            {
                ScCell.txtName.text = it.posX.ToString() + "," + it.posY.ToString();
            }    

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
                XNew = XNew + 1.205f;
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
        ResetPoint(objCellPoint);

        PlayMoveType(objCellPoint);
    }

    void PlayMoveType(List<Cell> listCell)
    {
        var listMoveDrop = listCell.Where(x=>x.MoveType == MoveType.Drop).Distinct().ToList();
        var listMoveRight = listCell.Where(x => x.MoveType == MoveType.Right).Distinct().ToList();
        var listMoveLeft = listCell.Where(x => x.MoveType == MoveType.Left).Distinct().ToList();
        var listMoveTop = listCell.Where(x => x.MoveType == MoveType.Top).Distinct().ToList();
        var listMoveBot = listCell.Where(x => x.MoveType == MoveType.Bot).Distinct().ToList();


        if (listMoveRight.Count > 0)
        {
            var listMoveRightNew = listMoveRight.OrderBy(x=>x.transform.position.x).ToList();
            List<int> uniqueX = listMoveRightNew.Select(o => o.PosInit.y).Distinct().ToList();
            foreach(var un in uniqueX )
            {
                List<Cell> cells = new();
                foreach (var item in listMoveRightNew)
                {
                    if (item.PosInit.y == un)
                    {
                        cells.Add(item);
                    }
                }

                if(cells.Count > 0)
                {
                    float pLimit = cells[cells.Count - 1].transform.position.x;

                    var dis = cells[0].transform.position.x - cells[1].transform.position.x;

                    dis = Math.Abs(dis);

                    pLimit += dis/2;

                    var pointReset = cells[0].transform.position + new Vector3(-dis / 2, 0, 0);
                    foreach (var item in cells)
                    {
                        item.OnMove(pLimit, pointReset);
                    }
                }
            }
        }

        if (listMoveLeft.Count > 0)
        {
            var listMoveLeftNew = listMoveLeft.OrderByDescending(x => x.transform.position.x).ToList();
            List<int> uniqueX = listMoveLeftNew.Select(o => o.PosInit.y).Distinct().ToList();
            foreach (var un in uniqueX)
            {
                List<Cell> cells = new();
                foreach (var item in listMoveLeftNew)
                {
                    if (item.PosInit.y == un)
                    {
                        cells.Add(item);
                    }
                }

                if (cells.Count > 0)
                {
                    float pLimit = cells[cells.Count - 1].transform.position.x;

                    var dis = cells[0].transform.position.x - cells[1].transform.position.x;

                    dis = Math.Abs(dis);

                    pLimit -= dis / 2;

                    var pointReset = cells[0].transform.position + new Vector3(dis / 2, 0, 0);
                    foreach (var item in cells)
                    {
                        item.OnMove(pLimit, pointReset);
                    }
                }
            }
        }

        if (listMoveTop.Count > 0)
        {
            var listMoveToptNew = listMoveTop.OrderBy(x => x.transform.position.y).ToList();
            List<int> uniqueX = listMoveToptNew.Select(o => o.PosInit.x).Distinct().ToList();
            foreach (var un in uniqueX)
            {
                List<Cell> cells = new();
                foreach (var item in listMoveToptNew)
                {
                    if (item.PosInit.x == un)
                    {
                        cells.Add(item);
                    }
                }

                if (cells.Count > 0)
                {
                    float pLimit = cells[cells.Count - 1].transform.position.y;

                    var dis = cells[0].transform.position.y - cells[1].transform.position.y;

                    dis = Math.Abs(dis);

                    pLimit += dis / 2;

                    var pointReset = cells[0].transform.position + new Vector3(0, -dis / 2, 0);
                    foreach (var item in cells)
                    {
                        item.OnMove(pLimit, pointReset);
                    }
                }
            }
        }

        if (listMoveBot.Count > 0)
        {
            var listMoveBottNew = listMoveBot.OrderByDescending(x => x.transform.position.y).ToList();
            List<int> uniqueX = listMoveBottNew.Select(o => o.PosInit.x).Distinct().ToList();
            foreach (var un in uniqueX)
            {
                List<Cell> cells = new();
                foreach (var item in listMoveBottNew)
                {
                    if (item.PosInit.x == un)
                    {
                        cells.Add(item);
                    }
                }

                if (cells.Count > 0)
                {
                    float pLimit = cells[cells.Count - 1].transform.position.y;

                    var dis = cells[0].transform.position.y - cells[1].transform.position.y;

                    dis = Math.Abs(dis);

                    pLimit -= dis / 2;

                    var pointReset = cells[0].transform.position + new Vector3(0, dis / 2, 0);
                    foreach (var item in cells)
                    {
                        item.OnMove(pLimit, pointReset);
                    }
                }
            }
        }

        if (listMoveDrop.Count > 0)
        {
            var listMoveDropNew = listMoveDrop.OrderByDescending(x => x.transform.position.y).ToList();
            List<int> uniqueX = listMoveDropNew.Select(o => o.PosInit.x).Distinct().ToList();
            foreach (var un in uniqueX)
            {
                List<Cell> cells = new();
                foreach (var item in listMoveDropNew)
                {
                    if (item.PosInit.x == un)
                    {
                        cells.Add(item);
                    }
                }

                if (cells.Count > 0)
                {
                    ListCellDrop.Add(cells);
                }
            }
        }
    }

    public void CheckRunAnimDrop(Cell cell)
    {
        foreach(var listC in ListCellDrop)
        {
            bool isRun = false;
            foreach (var item in listC)
            {
                if(cell.Equals(item))
                {
                    isRun = true;
                    listC.Remove(item);
                    break;
                }
            }

            if(listC.Count > 0 && isRun)
            {
                if(listC.Count > 1)
                {
                    var newList = listC.Where(x=>x.transform.position.y >= cell.transform.position.y).ToList();

                    var dis = listC[0].transform.localPosition.y - listC[1].transform.localPosition.y;
                    dis = Math.Abs(dis);
                    if(newList.Count == 1)
                    {
                        dis = dis / 2;
                    }    

                    foreach(var item in newList)
                    {
                        item.RunAnimCellDrop(() => {
                            item.transform.DOLocalMove(item.transform.localPosition - new Vector3(0, dis, 0), 0.1f).SetEase(Ease.InCubic);
                        });

                    }

                }
                break;
            }
        }
    }    

    private void Update()
    {
         
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

            var newCell1 = listCell.Where(x => (x.CellType == CellType.CellNormal || x.CellType == CellType.CellLayerCount) && x.MoveType == MoveType.Idle).Distinct().OrderBy(x => x.transform.position.y).ToList();
            if(newCell1.Count > 0)
            {
                foreach (var it in newCell1)
                {
                    XMin = Mathf.Min(XMin, it.transform.position.x);
                    XMax = Mathf.Max(XMax, it.transform.position.x);
                }
            }

            var cellN = listCell.Where(x => x.MoveType == MoveType.Idle && x.CellType == CellType.CellLayerCount).ToList();

            if(cellN.Count > 0)
            {
                XMax += 1.4f;
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

            float distanceY = 4.5f;

            p2.transform.position = new Vector2(0, pyMid - 0.5f);


            float distanceX = 3.6f;

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

            yMin = 99999; yMax = -99999;

            var pyMid = PTop.transform.position.y / 2 + PBot.transform.position.y / 2;

            XMax = -99999; XMin = 99999;
            var newCell1 = listCell.Where(x => x.CellType == CellType.CellNormal || x.CellType == CellType.CellLayerCount && x.MoveType == MoveType.Idle).Distinct().OrderBy(x => x.transform.position.y).ToList();
            foreach (var it in listCell)
            {
                XMin = Mathf.Min(XMin, it.transform.position.x);
                XMax = Mathf.Max(XMax, it.transform.position.x);
            }

            float distanceX = 3.6f;
            float dis = XMax - XMin;

            if (dis > sizeCamera.x - distanceX)
            {
                var sx = (sizeCamera.x - distanceX) / dis;
                p2.transform.localScale = Vector2.one * sx;
            }
        }
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

    public void CheckComboGame(Cell cell)
    {
        AnimPlayGame.Instance.PlayAnimStarCombo(UnityEngine.Random.Range(1, 10), cell.transform.position);
    }

    public void PlayAnimCombo()
    {
        if(!IsUIParticlePlaying(uiAnimStarCombo))
        {
            uiAnimStarCombo.Play();
        }

    }

    bool IsUIParticlePlaying(UIParticle uiParticle)
    {
        if (uiParticle == null) return false;

        var particles = uiParticle.particles;

        foreach (var ps in particles)
        {
            if (ps.isPlaying) return true;
        }

        return false;
    }

}
