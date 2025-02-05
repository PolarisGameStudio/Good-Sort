using System.Collections.Generic;
using UnityEngine;

public class BoardUtils
{
	private Vector2Int[] shapes;

	private bool CanPlaceShape(int[,] board, int row, int col, Vector2Int shape)
	{
		return false;
	}

	private void PlaceShape(int[,] board, int row, int col, Vector2Int shape, int shapeID)
	{
	}

	private void RemoveShape(int[,] board, int row, int col, Vector2Int shape)
	{
	}

	private bool SolveRandomly(int[,] board, int shapeIndex)
	{
		return false;
	}

	public void PrintBoard(int[,] board)
	{
	}

	public bool CanPutItemHidenInBoard(Vector2Int posIgnore, HalloweenData HalloweenData, List<int> itemRequire)
	{
		return false;
	}

	public List<ItemInBoard> CheckAndGenHidenLevel(HalloweenData halloweenData, List<int> itemRequire)
	{
		return null;
	}

	private List<Vector2Int[]> GeneratePossibleCombinations(Vector2Int[] shapes)
	{
		return null;
	}

	private void GenerateCombinations(Vector2Int[] shapes, int index, Vector2Int[] currentCombination, List<Vector2Int[]> result)
	{
	}
}
