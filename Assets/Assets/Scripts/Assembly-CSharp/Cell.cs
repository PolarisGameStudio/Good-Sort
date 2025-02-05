using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
	private bool _isLock;

	[SerializeField]
	private CellType _cellType;

	[SerializeField]
	private ItemContainer _itemContainer;

	private MoveType _moveType;

	private float _speed;

	private Vector2Int _posInit;

	private Vector2Int _curPos;

	public bool IsLock => false;

	public CellType CellType => default(CellType);

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

	private void OnValidate()
	{
	}

	public void SetData(List<ItemsInLayerCell> da)
	{
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
