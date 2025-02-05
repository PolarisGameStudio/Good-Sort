using System.Collections.Generic;
using UnityEngine;

namespace SuperScrollView
{
	public class ItemPool
	{
		private GameObject mPrefabObj;

		private string mPrefabName;

		private int mInitCreateCount;

		private float mPadding;

		private float mStartPosOffset;

		private List<LoopListViewItem2> mTmpPooledItemList;

		private List<LoopListViewItem2> mPooledItemList;

		private static int mCurItemIdCount;

		private RectTransform mItemParent;

		public void Init(GameObject prefabObj, float padding, float startPosOffset, int createCount, RectTransform parent)
		{
		}

		public LoopListViewItem2 GetItem(int itemIndexForSearch)
		{
			return null;
		}

		public void DestroyAllItem()
		{
		}

		public LoopListViewItem2 CreateItem()
		{
			return null;
		}

		public void RecycleItemReal(LoopListViewItem2 item)
		{
		}

		public void RecycleItem(LoopListViewItem2 item)
		{
		}

		public void ClearTmpRecycledItem()
		{
		}
	}
}
