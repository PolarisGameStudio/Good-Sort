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

	private MoveType _moveType;

	private float _speed;

	private Vector2Int _posInit;

	private Vector2Int _curPos;

	public bool IsLock => _isLock;

	public CellType CellType => _cellType;

	public ItemContainer ItemContainer => _itemContainer;

	public MoveType MoveType => default(MoveType);

	public float Speed => 0f;

	public Vector2Int PosInit => default(Vector2Int);

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
		//_healthBar.Init(max);
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

	public void SetData(List<ItemsInLayerCell> da, int typeCell)
	{
		_cellType = (CellType)typeCell;
        _itemContainer.SetupItem(this, da);
	}

	public void CheckEndItem(Item item)
	{
		_itemContainer.OnSucessMegerItem(item);

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
