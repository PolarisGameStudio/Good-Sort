using System;
using System.Collections.Generic;

[Serializable]
public class BoardData
{
	public IntArray[] board;

	public List<ItemInBoard> itemInBoards;

	public List<int> itemsCollected;
}
