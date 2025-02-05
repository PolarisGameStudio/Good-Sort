namespace SuperScrollView
{
	public class GridItemGroup
	{
		private int mCount;

		private int mGroupIndex;

		private LoopGridViewItem mFirst;

		private LoopGridViewItem mLast;

		public int Count => 0;

		public LoopGridViewItem First => null;

		public LoopGridViewItem Last => null;

		public int GroupIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public LoopGridViewItem GetItemByColumn(int column)
		{
			return null;
		}

		public LoopGridViewItem GetItemByRow(int row)
		{
			return null;
		}

		public void ReplaceItem(LoopGridViewItem curItem, LoopGridViewItem newItem)
		{
		}

		public void AddFirst(LoopGridViewItem newItem)
		{
		}

		public void AddLast(LoopGridViewItem newItem)
		{
		}

		public LoopGridViewItem RemoveFirst()
		{
			return null;
		}

		public LoopGridViewItem RemoveLast()
		{
			return null;
		}

		public void Clear()
		{
		}
	}
}
