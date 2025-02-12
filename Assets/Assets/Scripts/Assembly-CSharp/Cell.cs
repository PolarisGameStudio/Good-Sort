using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cell : MonoBehaviour
{
	private bool _isLock;

	[SerializeField]
	private CellType _cellType;

	[SerializeField]
	private ItemContainer _itemContainer;
	[SerializeField] private UICellHealthBar _healthBar;

    [SerializeField] private MoveType _moveType;

	private float _speed;

	private Vector2Int _posInit;

	private Vector2Int _curPos;

	public bool IsLock => _isLock;

	public CellType CellType => _cellType;

	public ItemContainer ItemContainer => _itemContainer;

	public MoveType MoveType => _moveType;
	bool IsMove = false;
	Vector2 PointReset = Vector2.zero;
	float PLimit = 0f;

	public float Speed => _speed;

	public Vector2Int PosInit => _posInit;

	public Vector2Int CurPos
	{
		get
		{
			return default(Vector2Int);
		}
		set
		{
		}
	}

	[HideInInspector]
	public CellLock cellLock = null;

	private void OnValidate()
	{
	}

	public void InitDotTypeCellOneSlot(int max)
	{
		_healthBar.Init(max);
    }

	public void RemoveDotTypeCellOneSlot()
	{
		_healthBar.RemoveDot();
    }

	public void OnLockCell(GameObject objLock)
	{
		_isLock = true;
        var obj = Instantiate(objLock, transform);
		cellLock = obj.GetComponent<CellLock>();
        _itemContainer.OnLockCell();
    }

	public void OnUpdateNumLock(int num)
	{
		cellLock.UpdateNumLock(num);
    }

    public void UnLockCellAllItem()
	{
        _isLock = false;
        _itemContainer.UnLockCell();
	}

	public void SetData(List<ItemsInLayerCell> da, int typeCell, int moveType, Vector2Int vec, float speed)
	{
        _speed = speed;
        _posInit = vec;
        _moveType = (MoveType)moveType;
        _cellType = (CellType)typeCell;
        _itemContainer.SetupItem(this, da);
	}


    public void CheckEndItem(Item item)
	{
		_itemContainer.OnSucessMegerItem(item);

    }

    private void Update()
    {
        if (IsMove)
        {
			if(_moveType == MoveType.Right)
			{
                transform.Translate(Vector3.right * Speed * Time.deltaTime);

                if (transform.position.x > PLimit)
                {
                    transform.position = PointReset;
                }
				return;
            }

            if (_moveType == MoveType.Left)
            {
                transform.Translate(Vector3.left * Speed * Time.deltaTime);
                if (transform.position.x < PLimit)
                {
                    transform.position = PointReset;
                }
				return;
            }

            if (_moveType == MoveType.Top)
            {
                transform.Translate(Vector3.up * Speed * Time.deltaTime);
                if (transform.position.y > PLimit)
                {
                    transform.position = PointReset;
                }
                return;
            }

            if (_moveType == MoveType.Bot)
            {
                transform.Translate(Vector3.down * Speed * Time.deltaTime);
                if (transform.position.y < PLimit)
                {
                    transform.position = PointReset;
                }
                return;
            }
        }
    }

    public void OnMove(float pLimit, Vector2 pointReset)
    {
		IsMove = true;
        PLimit = pLimit;
		PointReset = pointReset;
    }

    public void InitData(Vector2Int pos, MoveType moveType, float speed, bool isLock)
	{
	}

	public void Lock()
	{
	}

	public void UnLock()
	{
	}
}
