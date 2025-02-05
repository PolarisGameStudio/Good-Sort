using System.Collections.Generic;
using UnityEngine;

public class CellDropController : MonoBehaviour
{
	[SerializeField]
	private GenLevelController _genLevel;

	[SerializeField]
	private LevelController _levelController;

	[SerializeField]
	private AnimationCurve _curvesr;

	private int minY;

	private List<Cell> _cellsDrop;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void UpdateCell(Cell cell)
	{
	}

	private Vector2Int GetPosDrop(Cell cell)
	{
		return default(Vector2Int);
	}

	private List<Cell> GetCellAbove(Cell cell)
	{
		return null;
	}

	public void InitData(List<Cell> cells)
	{
	}
}
