using System.Collections.Generic;
using UnityEngine;

namespace SuperScrollView
{
	public class GridItemPool
	{
		private GameObject mPrefabObj;

		private string mPrefabName;

		private int mInitCreateCount;

		private List<LoopGridViewItem> mTmpPooledItemList;

		private List<LoopGridViewItem> mPooledItemList;

		private static int mCurItemIdCount;

		private RectTransform mItemParent;

		public void Init(GameObject prefabObj, int createCount, RectTransform parent)
		{
		}

		public LoopGridViewItem GetItem(int itemIndexForSearch)
		{
			return null;
		}

		public void DestroyAllItem()
		{
		}

		public LoopGridViewItem CreateItem()
		{
			return null;
		}

		private void RecycleItemReal(LoopGridViewItem item)
		{
		}

		public void RecycleItem(LoopGridViewItem item)
		{
		}

		public void ClearTmpRecycledItem()
		{
		}
	}
}
