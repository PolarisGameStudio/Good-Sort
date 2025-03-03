using Coffee.UIExtensions;
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

    void Start()
    {
        imgProgress.fillAmount = 0;
        DisableTextCombo();
        sizeCamera = GetSizeCameraInWord();
        OnLoadLevel();
        isShowWarnning = false;
        BoosterInGameController.Instance.ActiveBooster(BoosterKind.X2_Star);
    }

    public static Vector2 GetSizeCameraInWord()
    {
        Camera mainCamera = Camera.main;
        var height = mainCamera.orthographicSize * 2;
        var width = (float)Screen.width / (float)Screen.height * height;
        return new Vector2(width, height);
    }

    #region Load Level
    public void OnNextLevel()
    {
        //OnSkillBreakItem();
        // OnSkilFreeze();
        //OnSkillSwap();
        // OnPlayAnimationReplay();
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
    }

    public void OnLoadLevel()
    {
        isGameOver = true;
        ScStatic.currentStarGame = 0;
        var level = GenLevelController.Instance.GetDataLevel();
        textLevel.text = "Level " + (GenLevelController.Instance.LevelId + 1).ToString();
        if (GenLevelController.Instance.LevelId == 0)
        {
            _timePlayGame = 100000;
            textTimePlay.gameObject.SetActive(false);
        }
        else
        {
            _timePlayGame = level.timeToPlay;
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

        float xtt = Math.Abs(XMin) / 2 + Math.Abs(XMax) / 2;
        float ytt = Math.Abs(yMin) / 2 + Math.Abs(yMax) / 2;


        bool IsLock = false;

        List<Cell> listCells = new();


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
        ResetPoint(listCellAllGame);

        PlayMoveType(listCellAllGame);

        isGameOver = false;
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
            if(IsUseSkillFreeze || IsUseSkillGame)
            {
                yield return null;
                continue;
            }    
            timeCurrentCombo -= Time.deltaTime;
            float pecent = timeCurrentCombo / _timeCombo;
            if (pecent <= 0)
            {
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
        Debug.Log("combo: " + _currentCombo + " staradd__:" + _currentStarAdd +  "_currentStar___" + _currentStar);

        textCombo.text = "Combo X" + _currentCombo.ToString();
        textStar.text = _currentStar.ToString();
        ScStatic.currentStarGame = _currentStar;
        return _currentStarAdd;
    }

    public void CheckComboGame(Vector3 point)
    {
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

    private void Update()
    {
        if (isGameOver)
        {
            return;
        }
        if (listCellAllGame.Count > 0)
        {
            int count = listCellAllGame.Count;
            int index = 0;
            foreach (var item in listCellAllGame)
            {
                if(item == null || item.IsCheckCellBlank())
                {
                    index++;
                }    
            }

            if(index == count)
            {
                GameOver(true);
            }    
        }    

        if(IsUseSkillGame || IsUseSkillFreeze)
        {
            return;
        }    

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
            GameOver(false);
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
                            item.transform.DOLocalMove(item.transform.localPosition - new Vector3(0, dis, 0), 0.1f).SetEase(Ease.InCubic).OnComplete(() => { 
                            });
                        });

                    }

                }
                break;
            }
        }
    }

    #endregion

    #region SkillGame

    #region Skill Replay

    [Header("Skill Replay")]
    [SerializeField] private PowerupReplace _powerupReplace = null;

    public void PlayAnimationReplace(List<Item> cells, Action<ItemAsset, Vector3> callback)
    {
        _powerupReplace.Active(cells, callback);
    }

    public void OnPlayAnimationReplay()
    {
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
                IsUseSkillGame = false;
                return;
            }

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
        });
    }

    #endregion

    #region Skill Swap

    [Header("Skill Swap")]
    [SerializeField] private PowerupSwap _powerupSwap = null;

    public void OnSkillSwap()
    {
        var cell = listCellAllGame.Where(x => x != null && !x.IsCheckCellBlank() && !x.IsLock && x.transform.position.y < PTop.transform.position.y && x.transform.position.y > PBot.transform.position.y).ToList();

        _powerupSwap.gameObject.SetActive(true);
        IsUseSkillGame = true;
        _powerupSwap.OnSkillSwap(cell, p2.transform.position, () => {
            IsUseSkillGame = false;
            _powerupSwap.gameObject.SetActive(false);
        });
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
        yield return new WaitForSeconds(_TimeSkillFreeze);
        _powerupFreeze.gameObject.SetActive(false);
        IsUseSkillFreeze = false;
    }

    #endregion

    #region Skill Break Item
    [Header("Skill Break Item")]
    [SerializeField] private PowerupBreakItem _powerupBreakItem = null;

    public void OnSkillBreakItem()
    {
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
        }

        if(listItems.Count == 0)
        {
            IsUseSkillGame = false;
            return;
        }

        var numCombo = listItems.Count / 3;

        _powerupBreakItem.gameObject.SetActive(true);

        _powerupBreakItem.OnPlaySkillBreakItem(listItems, () => { 
            foreach(var cel in cell)
            {
                cel.OnNextItemWhenUseSkillBreakItem();
            }

            var ces = listCellAllGame.Where(x=>x != null).ToList();
            foreach(var ce in cell)
            {
                ce.OnCheckPlayAnimCellTypeDropBlank();
            }

            CheckCombo(numCombo);
            AnimPlayGame.Instance.OnPlayAnimCombo(Vector3.zero, numCombo, null);

            IsUseSkillGame = false;
        });
    }    

    private void CheckCombo(int countCombo)
    {
        for(int i = 0; i < countCombo; i++)
        {
			CheckComboGame(Vector3.zero);
            CheckObjectLock();
        }
    }

    #endregion

    #endregion

    #region Bosster

    public void OnBossterTimeBonus(Transform ob)
    {
        IsUseSkillGame = true;
        ob.DOMove(UICountDown.Instance.transform.position, 1.0f).SetEase(Ease.InBack).OnComplete(() => {
            IsUseSkillGame = false;
            ob.gameObject.SetActive(false);
            _timePlayGame += 60.0f;
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
    private void GameOver(bool isWin)
    {
        isGameOver = true;

        if(isGameOver)
        {
            StartCoroutine(StartGameOver());
        }
    }

    IEnumerator StartGameOver()
    {
        UIEndGame.Show();
        yield return new WaitForEndOfFrame();
        UIEndGame.Instance.EndGame(EndGameState.Win);
        yield return new WaitForSeconds(3.0f);
      //  OnNextLevel();
    }


    #endregion

    private void OnDestroy()
    {
        HelperManager.Save();
    }
}
