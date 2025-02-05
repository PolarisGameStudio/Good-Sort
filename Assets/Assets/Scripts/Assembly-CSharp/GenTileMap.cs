using System.Collections.Generic;
using UnityEngine;

public class GenTileMap : MonoBehaviour
{
	[SerializeField]
	private GameObject cell;

	[SerializeField]
	private int _width;

	[SerializeField]
	private int _height;

	[SerializeField]
	private float _cellSize;

	private List<GameObject> listCells;

	private List<GameObject> listShelfs;

	public void GenCell()
	{
	}

	public void ClearMap()
	{
	}

	public void SaveLevel()
	{
	}
}
