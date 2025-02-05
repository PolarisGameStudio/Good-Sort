namespace SuperScrollView
{
	public class ItemSizeGroup
	{
		public float[] mItemSizeArray;

		public float[] mItemStartPosArray;

		public int mItemCount;

		private int mDirtyBeginIndex;

		public float mGroupSize;

		public float mGroupStartPos;

		public float mGroupEndPos;

		public int mGroupIndex;

		private float mItemDefaultSize;

		private int mMaxNoZeroIndex;

		public bool IsDirty => false;

		public ItemSizeGroup(int index, float itemDefaultSize)
		{
		}

		public void Init()
		{
		}

		public float GetItemStartPos(int index)
		{
			return 0f;
		}

		public float SetItemSize(int index, float size)
		{
			return 0f;
		}

		public void SetItemCount(int count)
		{
		}

		public void RecalcGroupSize()
		{
		}

		public int GetItemIndexByPos(float pos)
		{
			return 0;
		}

		public void UpdateAllItemStartPos()
		{
		}

		public void ClearOldData()
		{
		}
	}
}
