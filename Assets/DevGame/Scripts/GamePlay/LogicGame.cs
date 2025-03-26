using Coffee.UIExtensions;
using Cysharp.Threading.Tasks.Linq;
using DG.Tweening;

using Spine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public struct DataItemSkillSwap
{
    public bool isNomal;
    public Item item;
    public Vector3 pointMove;
}
public class LogicGame : Singleton<LogicGame>
{
    [Header("Game Play")]
    public GameObject objSelll;
    public GameObject PrefabCellLock;

    public Transform PTop;
    public Transform PBot;

    private List<Cell> listCellLock = new();
    private List<Cell> listCellAllGame = new();
    int _currentLock = 0;
    float _timePlayGame = 0;
    public string TxtTimePlay = "";

    int _numCellLock = 0;
    int _numCellHiden = 0;

    public Transform p1 = null;
    public Transform p2 = null;
    public Transform p3 = null;
    public static Vector2 sizeCamera = Vector2.zero;
    List<List<Cell>> ListCellDrop = new();

    public UIParticle uiAnimStarCombo = null;

    [SerializeField] WarningLowTimeToPlay _warningLowTimeToPlay = null;

    [HideInInspector]
    public bool IsUseSkillGame = false;
    [SerializeField] TextMeshProUGUI textTimePlay;
    [SerializeField] TextMeshProUGUI textLevel;
    private bool isShowWarnning = false;

    public Dictionary<ItemType, float> ItemTypeScale = new();

    public bool IsStartGame = false;
    private bool IsPlayBooster = true;
    private bool IsLevelHard = false;

    private bool isPauseGame
    {
        get
        {
            return IsUseSkillGame || !IsStartGame || IsPlayBooster || isGameOver || IsStarPower || IsLevelHard;
        }
    }

    public bool IsPause
    {
        get
        {
            return IsUseSkillGame || IsPlayBooster || isGameOver || IsStarPower;
        }
    }

    public bool IsUseTutorial = false;

    public bool IsStarPower = false;

    void Start()
    {
        textStar.text = "0";
        Application.targetFrameRate = 60;
        imgProgress.fillAmount = 0;
        DisableTextCombo();
        sizeCamera = GetSizeCameraInWord();
        OnLoadLevel();
        isShowWarnning = false;
        this.StartCoroutine(OnPlayBooster());
    }

    public void UserClickScreen()
    {
        IsStartGame = true;
    }

    public static Vector2 GetSizeCameraInWord()
    {
        Camera mainCamera = Camera.main;
        var height = mainCamera.orthographicSize * 2;
        var width = (float)Screen.width / (float)Screen.height * height;
        return new Vector2(width, height);
    }

    public Cell GetCellByName(string name)
    {
        foreach(var cel in listCellAllGame)
        {
            if (cel.name ==name)
            {
                return cel;
            }
        }

        return null;
    }    

    #region Load Level
    public void OnNextLevel()
    {
        //OnSkillBreakItem();
        // OnSkilFreeze();
        //OnSkillSwap();
        // OnPlayAnimationReplay();
        SOItemContainer.Instance.OnAdd();
        HelperManager.DataPlayer.LevelID++;
        StartCoroutine(LoadData());
        isGameOver = false;
    }

    IEnumerator LoadData()
    {
        OnResetCombo();
        ListCellDrop.Clear();
        listCellLock.Clear();
        listCellAllGame.Clear();
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
        yield return new WaitForSeconds(1.5f);
    }

    public void AddCellToListCell(Cell cel)
    {
        if(listCellAllGame.Contains(cel))
        {
            return;
        }

        listCellAllGame.Add(cel);
    }

    public void OnLoadLevel()
    {
        isGameOver = true;
        var level = GenLevelController.Instance.GetDataLevel();
        textLevel.text = "LV " + (GenLevelController.Instance.LevelId + 1).ToString();
        if (GenLevelController.Instance.LevelId == 0)
        {
            _timePlayGame = 100000;
            textTimePlay.gameObject.SetActive(false);
            IsUseTutorial = true;
            var obj = Resources.Load<GameObject>("Prefabs/TutorialGame");
            var ob = Instantiate(obj);
            ob.transform.position = Vector3.zero;
            isGameOver = false;
            return;
        }
        else
        {
            _timePlayGame = level.timeToPlay;
        }

       // _timePlayGame = 10.0f;

        if ((GenLevelController.Instance.LevelId) % 5 == 0)
        {
            IsLevelHard = true;
            OnPlayWarningGame();
        }

        textTimePlay.text = GetTimePlayGame();

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

        bool IsLock = false;

        List<Cell> listCells = new();

        int posintXMax = -9999;
        int posintXMin = 9999;

        foreach (var it in cell)
        {
            var prefab = GenLevelController.Instance.GetPrefabCell(it.cellType);
            var obj = Instantiate(prefab.prefab.gameObject, p2);
            var ScCell = obj.GetComponent<Cell>();
            ScCell.SetData(it.itemsLayer, it.cellType, it.moveType, new Vector2Int(it.posX, it.posY), it.speed);
            listCellAllGame.Add(ScCell);
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


            var disX1 = Math.Abs(it.posX - XMin);
            var disY2 = Math.Abs(it.posY - yMin);


            float xAddd = 3.6f;

            if(it.cellType == 1)
            {
                //it.posX -= 4;
            }

            float XNew = it.posX;
            float YNew = it.posY;

            posintXMax = Math.Max((int)XNew, posintXMax);
            posintXMin = Math.Min((int)XNew, posintXMin);


            if (disX1 != 0)
            {
                if ((int)disX1 - disX1 < 0.1f)
                {
                    float pd = disX1 / 6.0f;
                    if (XMin < it.posX)
                    {
                        XNew = XMin - pd * xAddd;
                    }
                    else
                    {
                        XNew = XMin + pd * xAddd;
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
                XNew = XNew + 1.05f;
            }

            if(it.cellType == 3)
            {
                YNew += 0.3f;
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
        ResetPoint1();
        ResetPoint(listCellAllGame);

        XMin = 9999;
        XMax = -9999;

        foreach (var it in listCellAllGame)
        {
            XMin = Mathf.Min(XMin, it.pXMin.transform.position.x);
            XMax = Mathf.Max(XMax, it.pXMax.transform.position.x);
        }

        float pointMid = XMax / 2 + XMin / 2;

        foreach (var it in listCellAllGame)
        {
            it.transform.position += new Vector3(-pointMid, 0, 0);
        }

        PlayMoveType(listCellAllGame);
        isGameOver = false;
        CheckItem();

        foreach(var cel in listCellAllGame)
        {
            cel.OnUpdateSprite(posintXMax, posintXMin);
        }

    }

    void CheckItem()
    {
        List<Item> listItem = new();
        foreach(var it in listCellAllGame)
        {
            listItem.AddRange(it.GetAllItemOfCell());
        }

        var itemHide = listItem.Where(x=>x.isNameSpriteAndAspriteShadow()).ToList();

        List<ItemType> uniqueX = itemHide.Select(o => o.ItemType).Distinct().ToList();

        List<List<Item>> listItems = new();
        foreach (var item in uniqueX)
        {
            var lis1 = itemHide.Where(x=>x.ItemType == item).ToList();
            listItems.Add(lis1);
        }

        foreach(var items in listItems)
        {
     
           if(items.Count == 3)
           {
                var it0 = items[0];
                var asseet = SOItemContainer.Instance.GetItemAsset(it0._itemAsset.daIt.spriteHidden);
                items[1].SetNewItemAsset(asseet, true);
                items[2].SetNewItemAsset(asseet, true);
                items[0].SetNewItemAsset(asseet, true);
           }
        }    
    }

    void ResetPoint1()
    {
        var listMoveDrop = listCellAllGame.Where(x => x.CellType == CellType.CellSingle).Distinct().ToList();
        List<int> uniqueX = listMoveDrop.Select(o => o.PosInit.x).Distinct().ToList();


        List<List<Cell>> listCellR = new();

        var cels = listCellAllGame.OrderByDescending(x => x.transform.position.x).ToList();

        foreach (var un in uniqueX)
        {
            var cel = cels.Where(x => x.PosInit.x == un).Distinct().ToList();
            if (cel.Count > 0)
            {
                listCellR.Add(cel);
            }
        }

        foreach (var ce in listCellR)
        {
            float minDiss = -9999;
            var c1 = ce[0];
            var ceNews = cels.Where(x => (x.transform.position.x - c1.transform.position.x) > 0.1f).Distinct().ToList();
            float xadd = 0.28f;

            foreach (var it in ceNews)
            {
                it.transform.position += new Vector3(xadd, 0, 0);
            }


            foreach (var it in ce)
            {
                it.transform.position += new Vector3(xadd, 0, 0);
            }
        }
    }

    void PlayMoveType(List<Cell> listCell)
    {
        var listMoveDrop = listCell.Where(x => x.MoveType == MoveType.Drop).Distinct().ToList();
        var listMoveRight = listCell.Where(x => x.MoveType == MoveType.Right).Distinct().ToList();
        var listMoveLeft = listCell.Where(x => x.MoveType == MoveType.Left).Distinct().ToList();
        var listMoveTop = listCell.Where(x => x.MoveType == MoveType.Top).Distinct().ToList();
        var listMoveBot = listCell.Where(x => x.MoveType == MoveType.Bot).Distinct().ToList();


        if (listMoveRight.Count > 0)
        {
            var listMoveRightNew = listMoveRight.OrderBy(x => x.transform.position.x).ToList();
            List<int> uniqueX = listMoveRightNew.Select(o => o.PosInit.y).Distinct().ToList();
            foreach (var un in uniqueX)
            {
                List<Cell> cells = new();
                foreach (var item in listMoveRightNew)
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

                    pLimit += dis / 2;

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
            uniqueX.Sort((a, b)=>a-b);
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
                

                yMin = Mathf.Min(yMin, it.pYMin.transform.position.y);
                yMax = Mathf.Max(yMax, it.pYMax.transform.position.y);
            }

            XMax = -99999; XMin = 99999;

            var newCell1 = listCell.Where(x => (x.CellType == CellType.CellNormal || x.CellType == CellType.CellLayerCount) && x.MoveType == MoveType.Idle || x.MoveType == MoveType.Bot || x.MoveType == MoveType.Top).Distinct().OrderBy(x => x.transform.position.y).ToList();
            if(newCell1.Count > 0)
            {
                foreach (var it in newCell1)
                {
                    XMin = Mathf.Min(XMin, it.pXMin.transform.position.x);
                    XMax = Mathf.Max(XMax, it.pXMax.transform.position.x);
                }
            }

            var cellN = listCell.Where(x => x.MoveType == MoveType.Idle && x.CellType == CellType.CellLayerCount).ToList();

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

            float distanceY = 0.5f;

         //   p2.transform.position = new Vector2(0, pyMid - 0.5f);


            float distanceX = 0.5f;

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
            var newCell1 = listCell.Where(x => x.CellType == CellType.CellNormal || x.CellType == CellType.CellLayerCount && x.MoveType == MoveType.Idle || x.MoveType == MoveType.Bot || x.MoveType == MoveType.Top).Distinct().OrderBy(x => x.transform.position.y).ToList();
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


            var cellDrop = listCell.Where(x => x.MoveType == MoveType.Drop && x.CellType == CellType.CellNormal).ToList();
            if (cellDrop.Count > 0)
            {
               var cel = cellDrop[0];
                StartCoroutine(ResetScale(cel.transform, disPTopBot));

            }

        }

    }

    IEnumerator ResetScale(Transform tr, float disPTopBot)
    {
        yield return new WaitForEndOfFrame();

       /* var pointBegin = tr.transform.position;
        yield return new WaitForEndOfFrame();
        var inkk = disPTopBot / (2.4f * p2.transform.localScale.x);

        float fn = inkk - (int)inkk;

        float kk = Mathf.Ceil(inkk);

        if (fn < 0.5f)
        {
            kk = (int)inkk;
        }

        var newScele = disPTopBot / (2.4f * kk);
        p2.transform.localScale = Vector3.one * newScele;
        yield return new WaitForEndOfFrame();
        var pointBegin1 = tr.transform.position;
        var distance = pointBegin.y - pointBegin1.y;
        p2.transform.position += new Vector3(0, fn < 0.5f ? Mathf.Abs(distance) : - Mathf.Abs(distance), 0);*/

    }

    public void CheckObjectLock()
    {
        if(listCellLock.Count > 0)
        {
            var currentLock = listCellLock[0];
            _currentLock++;

            Audio.Play(ScStatic.SFX_Ingame_CellLock_Unlock);
            currentLock.OnUpdateNumLock(_currentLock);

            if (_currentLock == 4)
            {
                _currentLock = 0;
                listCellLock.Remove(currentLock);
                currentLock.UnLockCellAllItem();
            }
        }
    }

    #region Level Hard

    [Header("Spine_warning")]
    [SerializeField] GameObject objSpineWarning = null;
    private void OnPlayWarningGame()
    {
        Audio.Play(ScStatic.SFX_WARING);
        objSpineWarning.SetActive(true);
        StartCoroutine(PlayAnimWarning());
    }

    private IEnumerator PlayAnimWarning()
    {
        yield return new WaitForSeconds(2.0f);
        IsLevelHard = false;
        objSpineWarning.SetActive(false);
    }
    #endregion

    #endregion

    #region Combo

    [Header("ComboGame")]
    private int _currentStarAdd = 0;
    private int _currentStar = 0;

    private int _currentCombo = 0;
    public int CurrentCombo => _currentCombo;
    private int _currentIndexCombo = 0;

    private int _currIndexCheckAddIndexCombo = 0;
    private int _currCheckAddIndexCombo = 2;
    private int _comboX2 = 1;

    private bool _isAddCombo = false;

    private float _timeCombo = 25;
    [SerializeField] private UIParticle animComboProgress = null;
    [SerializeField] private TextMeshProUGUI textCombo = null;
    [SerializeField] private Image imgProgress = null;
    [SerializeField] private TextMeshProUGUI textStar = null;
    private Coroutine _coroutineCountTimeProgress = null;

    void DisableTextCombo()
    {
        textCombo.gameObject.SetActive(false);
    }

    IEnumerator CountTimeProgress()
    {
        float timeCurrentCombo = _timeCombo;
        while (true)
        {
            if(isPauseGame)
            {
                yield return null;
                continue;
            }    
            timeCurrentCombo -= Time.deltaTime;
            float pecent = timeCurrentCombo / _timeCombo;
            if (pecent <= 0)
            {
                Vibration.Vibrate(50);
                Audio.Play(ScStatic.SFX_LostCombo);
                OnResetCombo();
                pecent = 0;
                break;
            }
            imgProgress.fillAmount = pecent;
            yield return null;
        }
    }

    void OnResetCombo()
    {
        DisableTextCombo();
        _timeCombo = 25;
        imgProgress.fillAmount = 0;
        _currentCombo = 0;
        _currentIndexCombo = 0;
        _currCheckAddIndexCombo = 2;
    }

    private int UpdateCombo()
    {
        _currentCombo++;
        _currentIndexCombo++;

        if(_currentCombo == 1 || _currentCombo == 2)
        {
            _currentStarAdd = _comboX2;
        }
        else
        {

            if (_currentCombo % 2 != 0 || _currentCombo > 4)
            {
                _timeCombo--;
            }

            if (_currentIndexCombo > _currCheckAddIndexCombo)
            {
                _currentStarAdd += _comboX2;
                _currentIndexCombo = 0;
                _currIndexCheckAddIndexCombo++;
            }

            if (_currIndexCheckAddIndexCombo == 2)
            {
                _currCheckAddIndexCombo++;
                _currIndexCheckAddIndexCombo = 0;
            }

            _timeCombo = Math.Max(_timeCombo, 5);

        }
        _currentStar += _currentStarAdd;
       // Debug.Log("combo: " + _currentCombo + " staradd__:" + _currentStarAdd +  "_currentStar___" + _currentStar);

        textCombo.text = "Combo X" + _currentCombo.ToString();
        textStar.text = _currentStar.ToString();
        return _currentStarAdd;
    }
    public void CheckComboGame(Vector3 point, bool isPlaySound = true)
    {
        if(isPlaySound)
        {
            var index = Math.Min(_currentCombo, ScStatic.SFX_COMBOS.Count - 1);
            Audio.Play(ScStatic.SFX_COMBOS[index]);
        }

        textCombo.gameObject.SetActive(true);
        AnimPlayGame.Instance.PlayAnimStarCombo(UpdateCombo(), point);
        if (IsUIParticlePlaying(animComboProgress))
        {
            animComboProgress.Stop();
        }
        animComboProgress.Play();

        if(_coroutineCountTimeProgress != null)
        {
            StopCoroutine(_coroutineCountTimeProgress);
            _coroutineCountTimeProgress = null;
        }
        _coroutineCountTimeProgress = StartCoroutine(CountTimeProgress());
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
    #endregion

    #region Play Game

    string GetTimePlayGame()
    {
        TimeSpan time = TimeSpan.FromSeconds(_timePlayGame);
        return string.Format("{0}:{1:D2}", time.Minutes, time.Seconds);
    }

    public void CheckGameOver()
    {
        if (listCellAllGame.Count > 0)
        {
            int count = listCellAllGame.Count;
            int index = 0;
            foreach (var item in listCellAllGame)
            {
                if (item == null || item.IsCheckCellBlank())
                {
                    index++;
                }
            }

            if (index == count)
            {
                StartCoroutine(GameOver(true, 0));
            }
        }

    }

    public void CheckEnGameFullSlot()
    {
        var cell = listCellAllGame.Where(x=>x!=null).ToList();

        if (cell.Count > 0)
        {
            int count = cell.Count;
            int index = 0;
            foreach (var item in cell)
            {
                if (item.IsLayerFullSlot())
                {
                    index++;
                }
            }

            if (index == count)
            {
                StartCoroutine(GameOver(false, 1));
            }
        }
    }    

    private void Update()
    {
        if (isGameOver)
        {
            UICountDown.Instance.OnPauseAnimationClock();
            return;
        }

        if (isPauseGame)
        {
            UICountDown.Instance.OnPauseAnimationClock();
            return;
        }

        if (IsUseSkillGame || IsUseSkillFreeze)
        {
            UICountDown.Instance.OnPauseAnimationClock();
            return;
        }

        UICountDown.Instance.PlayAnimationClock();

        _timePlayGame -= Time.deltaTime;

        if(_timePlayGame < 60.0f)
        {
            ShowWarning();
        }
        else
        {
            DisableWarning();
        }

        if(_timePlayGame <= 0)
        {
            StartCoroutine(GameOver(false, 0));
            Debug.Log("game_over");
            return;
        }

        TxtTimePlay = GetTimePlayGame();

        textTimePlay.text = TxtTimePlay;
    }

    private void ShowWarning()
    {
        if(isShowWarnning)
        {
            return;
        }

        Audio.Play(ScStatic.SFX_Ingame_Warning);

        isShowWarnning = true;
        UICountDown.Instance.OnActiveAnimWarning(true);
        _warningLowTimeToPlay.SetActiveFx(true);
    }    

    public void DisableWarning()
    {
        if(!isShowWarnning)
        {
            return;
        }
        isShowWarnning = false;
        UICountDown.Instance.OnActiveAnimWarning(false);
        _warningLowTimeToPlay.SetActiveFx(false);
    }

    public void CheckRunAnimDrop(Cell cell)
    {
        foreach (var listC in ListCellDrop)
        {
            bool isRun = false;
            foreach (var item in listC)
            {
                if (cell.Equals(item))
                {
                    isRun = true;
                    listC.Remove(item);
                    break;
                }
            }

            if (listC.Count > 0 && isRun)
            {
                if (listC.Count > 1)
                {
                    var newList = listC.Where(x => x.transform.position.y >= cell.transform.position.y).ToList();

                    var dis = listC[0].transform.localPosition.y - listC[1].transform.localPosition.y;
                    dis = Math.Abs(dis);
                    if (newList.Count == 1)
                    {
                        dis = dis / 2;
                    }

                    foreach (var item in newList)
                    {
                        item.RunAnimCellDrop(() => {
                            Audio.Play(ScStatic.SFX_Ingame_CellDrop);
                            item.transform.DOLocalMove(item.transform.localPosition - new Vector3(0, dis, 0), 0.1f).SetEase(Ease.InCubic).OnComplete(() => { 
                            });
                        });

                    }

                }
                break;
            }
        }
    }

    public void AddScale(ItemType type, float scale)
    {
        if (ItemTypeScale.ContainsKey(type))
        {
            return;
        }
        ItemTypeScale.Add(type, scale);
    }   
    
    public float GetScaleItem(ItemType type)
    {
        if (ItemTypeScale.ContainsKey(type))
        {
            return ItemTypeScale[type];
        }
        return 0;
    }    

    #endregion

    #region SkillGame

    #region Skill Replay

    [Header("Skill Replay")]
    [SerializeField] private PowerupReplace _powerupReplace = null;

    public void PlayAnimationReplace(List<Item> cells, Action<ItemAsset, Vector3> callback)
    {
        Debug.Log("Replay_-2");

        _powerupReplace.Active(cells, callback);
    }

    public void OnPlayAnimationReplay()
    {
        Debug.Log("Replay_-1");

        IsUseSkillGame = true;
        List<LayerItem> listLayers = new();

        var cell = listCellAllGame.Where(x => x != null && !x.IsCheckCellBlank() && !x.IsLock && x.transform.position.y < PTop.transform.position.y && x.transform.position.y > PBot.transform.position.y).ToList();

        foreach (var cel in cell)
        {
            if(cel.IsLock)
            {
                continue;
            }
            listLayers.Add(cel.GetCurrentLayer());
        }

        List<Item> listItem = new();
        foreach(var it in listLayers)
        {
            listItem.AddRange(it.GetListItem());
        }

        var groupedPositions = listItem.GroupBy(pos => pos.ItemType).ToDictionary(group => group.Key, group => group.ToList());

        var sortedDict = groupedPositions.OrderByDescending(pair => pair.Value.Count % 3 == 0).ToDictionary(pair => pair.Key, pair => pair.Value);
        List<Item> listItemSkillReplay = new();

        foreach(var item in sortedDict)
        {
            listItemSkillReplay.AddRange(item.Value);

            if(listItemSkillReplay.Count >= 9)
            {
                break;
            }
        }    
        
        while(listItemSkillReplay.Count > 9)
        {
            listItemSkillReplay.RemoveAt(0);
        }

        _powerupReplace.gameObject.SetActive(true);

        groupedPositions = listItemSkillReplay.GroupBy(pos => pos.ItemType).ToDictionary(group => group.Key, group => group.ToList());


        Dictionary<ItemType, int> dictItem = new();


        foreach (var it in groupedPositions)
        {
            if (it.Value.Count % 3 == 0)
            {
                continue;
            }

            var countAdd = 3 - it.Value.Count % 3;
            dictItem.Add(it.Key, countAdd);
        }

        PlayAnimationReplace(listItemSkillReplay, (itemAsset, localScaleItem) => {
            if(dictItem.Count == 0)
            {
                Debug.Log("Replay_-4");
                IsUseSkillGame = false;
                UI_InGame_PowerUp.instance.OnSucess(PowerupKind.Replace, true);
                return;
            }
            Debug.Log("Replay_-4");
            foreach (var it in dictItem)
            {
                var countAdd = it.Value;
                var type = it.Key;

                var ListItem = new List<Item>();

                foreach(var cel in listCellAllGame)
                {
                    var listItems = cel.GetListItem(type, countAdd, 1);
                    if(listItems.Count > 0)
                    {
                        ListItem.AddRange(listItems);
                    }

                    if(ListItem.Count >= countAdd)
                    {
                        break;
                    }
                }

                if(ListItem.Count < countAdd)
                {
                    ListItem.Clear();
                    foreach (var cel in listCellAllGame)
                    {
                        var listItems = cel.GetListItem(type, countAdd, 0);
                        if (listItems.Count > 0)
                        {
                            ListItem.AddRange(listItems);
                        }

                        if (ListItem.Count >= countAdd)
                        {
                            break;
                        }
                    }
                }

                while(true)
                {
                    if(ListItem.Count > countAdd)
                    {
                        ListItem.RemoveAt(0);
                    }
                    else
                    {
                        break;
                    }
                }

                foreach(var item in ListItem)
                {
                    item.UpdateScaleCurrent(localScaleItem);
                    item.SetNewItemAsset(itemAsset);
                }
               
            }
            IsUseSkillGame = false;
            CheckGameOver();
        });
    }

    #endregion

    #region Skill Swap

    [Header("Skill Swap")]
    [SerializeField] private PowerupSwap _powerupSwap = null;

    public void OnSkillSwap(bool isOver = false)
    {
        isGameOver = false;
        var cell = listCellAllGame.Where(x => x != null && !x.IsCheckCellBlank() && !x.IsLock && x.transform.position.y < PTop.transform.position.y && x.transform.position.y > PBot.transform.position.y).ToList();
        StartCoroutine(PlayAudioSkillSwap());
        _powerupSwap.gameObject.SetActive(true);
        IsUseSkillGame = true;
        _powerupSwap.OnSkillSwap(cell, p2.transform.position, () => {
            IsUseSkillGame = false;
            _powerupSwap.gameObject.SetActive(false);
            CheckGameOver();
        }, isOver);
    }

    private IEnumerator PlayAudioSkillSwap()
    {
        Audio.Play(ScStatic.SFX_Ingame_UsePowerUp);
        float time = 0.4f;
        yield return new WaitForSeconds(time);
        Audio.Play(ScStatic.SFX_Ingame_PowerUp_Swap);
    }

    #endregion

    #region Skill Freeze

    [Header("Skill Freeze")]
    [SerializeField] private PowerupFreeze _powerupFreeze = null;
    [SerializeField] private float _TimeSkillFreeze = 10;
    Coroutine coroutineFreeze = null;
    private bool IsUseSkillFreeze = false;

    public void OnSkilFreeze()
    {
        IsUseSkillFreeze = true;
        _powerupFreeze.gameObject.SetActive(true);
        coroutineFreeze = StartCoroutine(StartSkillGameFreeze());
    }

    IEnumerator StartSkillGameFreeze()
    {
        float time = 0.03f;
        Audio.Play(ScStatic.SFX_Ingame_UsePowerUp);
        yield return new WaitForSeconds(time);
        Audio.Play(ScStatic.SFX_Ingame_PowerUp_TimeFreeze, 1, true);
        yield return new WaitForSeconds(_TimeSkillFreeze - time);
        Audio.Stop(ScStatic.SFX_Ingame_PowerUp_TimeFreeze);
        _powerupFreeze.gameObject.SetActive(false);
        IsUseSkillFreeze = false;
    }

    #endregion

    #region Skill Break Item
    [Header("Skill Break Item")]
    [SerializeField] private PowerupBreakItem _powerupBreakItem = null;

    public void OnSkillBreakItem(bool isBosster)
    {
        UnityEngine.Debug.Log("Hammer_-1");
        IsUseSkillGame = true;

        var cell = listCellAllGame.Where(x=>x!=null && !x.IsCheckCellBlank() && !x.IsLock && x.transform.position.y < PTop.transform.position.y && x.transform.position.y > PBot.transform.position.y).ToList();

        List<Item> listItem = new();

        foreach(var ce in cell)
        {
            var its = ce.GetListItemForSkillBreakItem();
            if(its == null || its.Count == 0)
            {
                continue;
            }
            listItem.AddRange(its);
        }    

        var  groupedPositions = listItem.GroupBy(pos => pos.ItemType).ToDictionary(group => group.Key, group => group.ToList());

        if(groupedPositions == null || groupedPositions.Count == 0)
        {
            IsUseSkillGame = false;
            UnityEngine.Debug.Log("Hammer_-2");
            UI_InGame_PowerUp.instance.OnSucess(PowerupKind.BreakItem, true);
            return;
        }

        var gr1 = groupedPositions.Where(x=>x.Value.Count > 2).ToList();

        foreach(var it in gr1)
        {
            var pd = it.Value.Count % 3;
            if(pd == 0)
            {
                continue;
            }

            for(int i = 0; i < pd; i++)
            {
                it.Value.RemoveAt(0);
            }
           
        }

        List<Item> listItems = new();

        foreach (var it in gr1)
        {
            listItems.AddRange(it.Value);
            if (!isBosster)
            {
                if(listItems.Count > 3)
                {
                    while(listItems.Count > 3)
                    {
                        listItems.RemoveAt(0);
                    }    
                }    
                break;
            }
        }

        if(listItems.Count == 0)
        {
            IsUseSkillGame = false;
            UnityEngine.Debug.Log("Hammer_-3");
            UI_InGame_PowerUp.instance.OnSucess(PowerupKind.BreakItem, true);
            return;
        }

        var numCombo = listItems.Count / 3;

        _powerupBreakItem.gameObject.SetActive(true);
        StartCoroutine(OnPlaySkillBreakItem(listItems, cell, numCombo, isBosster));
    }

    public IEnumerator OnPlaySkillBreakItem(List<Item> listItems, List<Cell> cell, int numCombo, bool isBosster)
    {
        float time = 0.03f;
        Audio.Play(ScStatic.SFX_Ingame_UsePowerUp);
        yield return new WaitForSeconds(time);
        Audio.Play(isBosster ? ScStatic.SFX_Ingame_Booster_Hammer : ScStatic.SFX_Ingame_PowerUp_Hammer);
        _powerupBreakItem.gameObject.SetActive(true);
        yield return new WaitForEndOfFrame();
         _powerupBreakItem.OnPlaySkillBreakItem(listItems, () => {
             Vibration.Vibrate(100);
             UnityEngine.Debug.Log("Hammer_-End");
               foreach (var cel in cell)
               {
                   cel.OnNextItemWhenUseSkillBreakItem();
               }

               var ces = listCellAllGame.Where(x => x != null && x.MoveType == MoveType.Drop && x.IsCheckCellBlank()).ToList();

             if(ces.Count > 0)
             {
                 PlayAnimCellTypeDropBlank(ces);
             }


             CheckCombo(numCombo);
               AnimPlayGame.Instance.OnPlayAnimCombo(Vector3.zero, numCombo, null);

               IsUseSkillGame = false;
               CheckGameOver();
           });
    }


    float distanceMoveDrop = 0;

    public void PlayAnimCellTypeDropBlank(List<Cell> cells)
    {
        float distance = 0;

        if(distanceMoveDrop < 0.01f)
        {
            foreach (var item in ListCellDrop)
            {
                if (item.Count > 01)
                {
                    var newL = item.OrderBy(x => x.transform.position.y).ToList();
                    var dis = newL[0].transform.localPosition.y - newL[1].transform.localPosition.y;
                    distanceMoveDrop = Math.Abs(dis);
                }
            }
        }

        List<List<Cell>> listCell = new();
        foreach (var lisc in ListCellDrop)
        {
            List<Cell> lcells = new();
            foreach (var c in cells)
            {
                foreach (var item in lisc)
                {
                    if (item.Equals(c))
                    {
                        lcells.Add(item);
                        lisc.Remove(item);
                        break;
                    }
                }
            }
            if(lcells.Count > 0)
            {
                listCell.Add(lcells);
            }
        }
        List<List<Cell>> listCellMove = new();
        foreach (var lisc in listCell)
        {
            for (int i = 0; i < lisc.Count; i++)
            {
                foreach (var l in ListCellDrop)
                {

                    var lx = l.Where(x=>x.transform.localPosition.y > lisc[i].transform.localPosition.y && x.PosInit.x == lisc[i].PosInit.x).ToList();
                    if(lx.Count > 0)
                    {
                        listCellMove.Add(lx);
                        break;
                    }
                }
            }
        }
        foreach (var lisc in listCellMove)
        {
            foreach(var item in lisc)
            {
                item.RunAnimCellDrop(() => {
                    Audio.Play(ScStatic.SFX_Ingame_CellDrop);
                    item.transform.DOLocalMove(item.transform.localPosition - new Vector3(0, distanceMoveDrop, 0), 0.1f).SetEase(Ease.InCubic).OnComplete(() => {
                        
                    });
                });
            }
        }
        this.StartCoroutine(RemoveCellDrop(cells));
    }

    IEnumerator RemoveCellDrop(List<Cell> cells)
    {
        yield return new WaitForSeconds(0.1f);
        foreach(var it in cells)
        {
            Destroy(it.gameObject);
        }
    }

    private void CheckCombo(int countCombo)
    {
        for(int i = 0; i < countCombo; i++)
        {
			CheckComboGame(Vector3.zero, false);
            CheckObjectLock();
        }
    }

    #endregion

    #endregion

    #region Bosster

    private IEnumerator OnPlayBooster()
    {
        IsPlayBooster = true;
        if (ScStatic.ListBoosterStart.Count > 0)
        {
            if (ScStatic.ListBoosterStart.Contains(BoosterKind.X2_Star))
            {
                yield return new WaitForEndOfFrame();
                Audio.Play(ScStatic.SFX_Ingame_Booster_2xStar);
                BoosterInGameController.Instance.ActiveBooster(BoosterKind.X2_Star);
                yield return new WaitForSeconds(1.2f);
            }

            if (ScStatic.ListBoosterStart.Contains(BoosterKind.BreakItem))
            {
                BoosterInGameController.Instance.ActiveBooster(BoosterKind.BreakItem);

                while (true)
                {
                    if (!IsUseSkillGame)
                    {
                        break;
                    }
                    yield return null;
                }
                yield return new WaitForEndOfFrame();
                yield return new WaitForEndOfFrame();
            }

            if (ScStatic.ListBoosterStart.Contains(BoosterKind.IncreaseTime))
            {
                yield return new WaitForEndOfFrame();
                BoosterInGameController.Instance.ActiveBooster(BoosterKind.IncreaseTime, 60.5f);
                while (true)
                {
                    if (!IsUseSkillGame)
                    {
                        break;
                    }
                    yield return null;
                }
            }

            ScStatic.ListBoosterStart.Clear();
        }
        IsPlayBooster = false;
    }

    private void OnBoosterX2Star()
    {

    }

    public void OnBossterTimeBonus(Transform ob, float time)
    {
        Audio.Play(ScStatic.SFX_Ingame_PowerUp_TimeBonus);
        IsUseSkillGame = true;
        ob.DOMove(UICountDown.Instance.transform.position, 1.0f).SetEase(Ease.InBack).OnComplete(() => {
            Vibration.Vibrate(100);
            IsUseSkillGame = false;
            ob.gameObject.SetActive(false);
            _timePlayGame += time;
            textTimePlay.text = GetTimePlayGame();
            UICountDown.Instance.IncreaseTime(60);
        }).SetDelay(1.0f);
    }

    public void OnBossterX2Start()
    {
        _comboX2 = 2;
    }

    #endregion

    #region End Game
    [Header("End Game")]
    private bool isGameOver = false;
    private IEnumerator GameOver(bool isWin, int type)
    {
        isGameOver = true;

        while(IsUseSkillGame || IsPlayBooster)
        {
            yield return null;
        }    

        _warningLowTimeToPlay.SetActiveFx(false);
        if(isWin)
        {
            HelperManager.DataPlayer.currentStarGame = _currentStar;
            HelperManager.DataPlayer.LevelID++;
         //   Audio.Play(ScStatic.SFX_Ingame_FoodFight_ConfettiWin);
            Audio.Play(ScStatic.SFX_In_game_Fire_word);
            Audio.Play(ScStatic.SFX_Ingame_Win);
            StartCoroutine(StartGameOver());
        }
        else
        {
            HelperManager.DataPlayer.currentStarGame = 0;
            Audio.Play(ScStatic.SFX_Ingame_FoodFight_ConfettiLose);
            if(type == 0)
            {
                UIPopup_EndGame_TimeUp.Show();
            }
            else
            {
                UIPopup_InGame_GameOver.Show();
            }
        }
    }

    IEnumerator StartGameOver()
    {
        UIEndGame.Show();
        yield return new WaitForEndOfFrame();
        yield return new WaitForSeconds(1.0f);
      //  Audio.Play(ScStatic.SFX_Ingame_Confetti);
        UIEndGame.Instance.EndGame(EndGameState.Win);
      //  OnNextLevel();
    }

    public void OnBossterTimeUp()
    {
        isGameOver = false;
        BoosterInGameController.Instance.ActiveBooster(BoosterKind.IncreaseTime, 30.5f);
    }

    #endregion

    #region Show UI

    public void OnSetting()
    {
        UI_Setting.Show();
        IsPlayBooster = true;
        UI_Setting.Instance.callbackShowSetting = () => {
            IsPlayBooster = false;
        };
    }    

    #endregion

    private void OnDestroy()
    {
        HelperManager.Save();
    }

}
