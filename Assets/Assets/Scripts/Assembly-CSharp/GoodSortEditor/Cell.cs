using System;
using System.Collections.Generic;
using UnityEngine;

namespace GoodSortEditor
{
	[Serializable]
	public class Cell
	{
		public Vector2 pos;

		public CellType type;

		public int numberLayer;

		public MoveType moveType;

		public float speed;

		public GameObject go;

		public List<List<Item>> items;
	}
}
