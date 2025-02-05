using System;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShelf : MonoBehaviour
{
	[Serializable]
	public class ShelfPrefabs
	{
		public CellType type;

		public GameObject prefabs;

		public int width;

		public int height;
	}

	[SerializeField]
	private CellType type;

	[SerializeField]
	private GameObject level;

	[SerializeField]
	public List<ShelfPrefabs> listShelf;

	private Vector3 spawnPosition;

	public void Spawnshelf()
	{
	}
}
