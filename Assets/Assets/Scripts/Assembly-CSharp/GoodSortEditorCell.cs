using System.Collections.Generic;
using UnityEngine;

public class GoodSortEditorCell : MonoBehaviour
{
	[SerializeField]
	private CellType _type;

	[SerializeField]
	private int _numberLayer;

	[SerializeField]
	private MoveType _moveType;

	[SerializeField]
	private float _speed;

	private Vector2Int _pos;

	private int _isLock;

	private List<List<GoodSortEditorItem>> _layerItems;

	private GoodSortEditorBoard _board;

	public Transform iconLock;

	public int Width => 0;

	public int Height => 0;

	public int WidthContain => 0;

	public int HeightContain => 0;

	public CellType Type
	{
		get
		{
			return default(CellType);
		}
		set
		{
		}
	}

	public int NumberLayer => 0;

	public MoveType MoveType
	{
		get
		{
			return default(MoveType);
		}
		set
		{
		}
	}

	public float Speed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Vector2Int Pos
	{
		get
		{
			return default(Vector2Int);
		}
		set
		{
		}
	}

	public int IsLock
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public List<List<GoodSortEditorItem>> LayerItems
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GoodSortEditorBoard Board
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void UpdateIconLock()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetUpData(Cell cell)
	{
	}

	public void SetIconLock(Transform iconLockPrefab)
	{
	}

	public Vector3 GetMousePosition()
	{
		return default(Vector3);
	}

	public (Vector3, int) GetNearestPosInCell(GoodSortEditorItem item)
	{
		return default((Vector3, int));
	}

	public Vector3 GetPos(int indexItem)
	{
		return default(Vector3);
	}

	public void UpdatePosItem()
	{
	}

	public int GetNumSlotEmptyInCurrentLayer()
	{
		return 0;
	}

	public int GetIndexSlotEmptyInCurrentLayer()
	{
		return 0;
	}

	public bool IsPreLayerNotNull()
	{
		return false;
	}

	public bool IsLayerNotNull(int layer)
	{
		return false;
	}

	public void AddLayer(int layer)
	{
	}

	public AddItemToCellState AddItem(GoodSortEditorItem item)
	{
		return default(AddItemToCellState);
	}

	public void ResetItem(GoodSortEditorItem item)
	{
	}

	public void RemoveItem(GoodSortEditorItem item)
	{
	}

	public void OnBoardChangeLayer(int currentLayer)
	{
	}

	public int GetTotalLayers()
	{
		return 0;
	}

	private void Test_ShowAllItemInLayer()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
