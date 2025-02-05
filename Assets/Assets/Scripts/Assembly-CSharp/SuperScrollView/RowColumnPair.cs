namespace SuperScrollView
{
	public struct RowColumnPair
	{
		public int mRow;

		public int mColumn;

		public RowColumnPair(int row1, int column1)
		{
			mRow = 0;
			mColumn = 0;
		}

		public bool Equals(RowColumnPair other)
		{
			return false;
		}

		public static bool operator ==(RowColumnPair a, RowColumnPair b)
		{
			return false;
		}

		public static bool operator !=(RowColumnPair a, RowColumnPair b)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
