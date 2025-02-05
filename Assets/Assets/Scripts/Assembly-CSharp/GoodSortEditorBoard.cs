using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoodSortEditorBoard : Singleton<GoodSortEditorBoard>
{
	[SerializeField]
	private SOCell _soCell;

	private Vector2Int _boardSize;

	[SerializeField]
	private float _cellUnitSize;

	[SerializeField]
	private Transform _parentCells;

	[SerializeField]
	private Transform _parentItems;

	[SerializeField]
	private Transform _centerPoint;

	private float _defaultWidthHeight;

	[SerializeField]
	private LineRenderer _lineBorder;

	[SerializeField]
	private float _widthView;

	private Vector3[] _corners;

	[SerializeField]
	private LineRenderer _lineBorderAvailable;

	[SerializeField]
	private float _widthAvailable;

	private Vector3[] _cornersAvailable;

	private List<GoodSortEditorCell> _cells;

	private int _currentLayerIndex;

	private int preLayer;

	private List<GameObject> textNums;

	public GameObject textNumPrefab;

	public Dictionary<Vector2Int, CellType?> cellTypeByPos;

	public RawImage rawImage;

	public static bool isDraw;

	public float updateInterval;

	private float accum;

	private int frames;

	private float timeleft;

	private float fps;

	public Vector2Int BoardSize => default(Vector2Int);

	public float CellUnitSize => 0f;

	public Transform ParentCells => null;

	public Transform ParentItems => null;

	public List<GoodSortEditorCell> Cells => null;

	public int CurrentLayerIndex => 0;

	protected override void Awake()
	{
	}

	public void UpdateBoardSize(Vector2Int vector2)
	{
	}

	private void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	private Vector2Int GetBoardSize(LevelInfo levelInfo)
	{
		return default(Vector2Int);
	}

	public void ImportNew(SOLevel soLevel)
	{
	}

	public void Import(LevelInfoEditorExtend levelInfo)
	{
	}

	private void SetupBoard()
	{
	}

	private void DrawBorderView(float widthView)
	{
	}

	private void DrawBorderAvailable(float widthAvailable)
	{
	}

	public void DeleteCell(GoodSortEditorCell cell)
	{
	}

	public void DeleteItem(GoodSortEditorItem item, bool callback = true)
	{
	}

	public void EndDrag(GoodSortEditorItem item)
	{
	}

	public void PutItemToCell(GoodSortEditorItem item, GoodSortEditorCell cell)
	{
	}

	public void EndDrag(GoodSortEditorCell cell)
	{
	}

	public void UpdateCellPos()
	{
	}

	public void NextLayer()
	{
	}

	public void PreviousLayer()
	{
	}

	public void ChangeLayer(int newLayer)
	{
	}

	public void DeleteAllITemInCell()
	{
	}

	public void DeleteItemInCurrentLayer()
	{
	}

	public void AutoFillItemToCurrentLayer(int numMatch3, int numMatch2, int numMatch1, bool usItemInPreLayer)
	{
	}

	public void AutoFillItemToLayer1_2(int numMatch3, int numMatch2, int numMatch1, int totalMatch3, int numMatch3Layer2, int numMatch2Layer2, int numMatch1Layer2)
	{
	}

	public bool IsPreLayerNotNull()
	{
		return false;
	}

	public int GetNumSlotEmptyInCurrentLayer()
	{
		return 0;
	}

	public Dictionary<ItemType, int> GetItemramain()
	{
		return null;
	}

	private void Update()
	{
	}

	public void ShowNumItemInItem()
	{
	}

	public void DetroyTextNumber()
	{
	}

	public int GetTotalLayers()
	{
		return 0;
	}

	public Vector2 GetPosInBoard(int x, int y)
	{
		return default(Vector2);
	}

	public Vector2 GetSize(int x, int y)
	{
		return default(Vector2);
	}

	public void UpdateCellTypeByPos()
	{
	}

	public void Capture()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void UpdateFPS()
	{
	}

	private void OnGUI()
	{
	}

	public void SetCenter(Transform t1, Transform t2, Transform t3)
	{
	}
}
