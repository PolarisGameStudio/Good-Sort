using System;
using System.Collections.Generic;
using UnityEngine;

public class CellLockController : MonoBehaviour
{
	[Serializable]
	public class CellLockData
	{
		public Cell cell;

		public CellLock cellLock;

		public int num;

		public CellLockData(Cell cell, CellLock cellLock, int num)
		{
		}

		public void UpdateVisual()
		{
		}
	}

	private int _cellLockType;

	[SerializeField]
	private LayerMask _layerCellLock;

	[SerializeField]
	private CellLock _cellLockPrefab;

	private List<CellLockData> _cellLocks;

	private const int num_lock = 4;

	private Camera mainCamera;

	private Vector2 _startPosDown;

	private CellLock _cellLock;

	private CellLockData GetCellLockData(CellLock cellLock)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnActiveMatch3(Vector2 pos)
	{
	}

	private void DecreaseLock(CellLockData cellLock)
	{
	}

	private void UnLock(CellLockData cellLock)
	{
	}

	public void InitData(List<Cell> cells, int numLock)
	{
	}

	private void Update()
	{
	}

	private void Raycasting()
	{
	}

	private void TrySelectingITem()
	{
	}

	public bool CanUnlockCellLockByGold()
	{
		return false;
	}

	public void UnLockCellLockByGold(CellLockData cellLockData)
	{
	}

	public void UnLockCellLockByAd(CellLockData cellLockData, Action OnComplete)
	{
	}
}
