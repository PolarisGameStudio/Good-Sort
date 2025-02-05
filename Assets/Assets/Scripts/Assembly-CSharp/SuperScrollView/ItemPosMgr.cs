using System.Collections.Generic;

namespace SuperScrollView
{
	public class ItemPosMgr
	{
		public const int mItemMaxCountPerGroup = 100;

		private List<ItemSizeGroup> mItemSizeGroupList;

		private int mDirtyBeginIndex;

		public float mTotalSize;

		public float mItemDefaultSize;

		private int mMaxNotEmptyGroupIndex;

		public ItemPosMgr(float itemDefaultSize)
		{
		}

		public void SetItemMaxCount(int maxCount)
		{
		}

		public void SetItemSize(int itemIndex, float size)
		{
		}

		public float GetItemPos(int itemIndex)
		{
			return 0f;
		}

		public bool GetItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos)
		{
			return false;
		}

		public void Update(bool updateAll)
		{
		}
	}
}
