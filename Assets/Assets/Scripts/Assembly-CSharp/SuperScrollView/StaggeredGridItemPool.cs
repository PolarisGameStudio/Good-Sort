using System.Collections.Generic;
using UnityEngine;

namespace SuperScrollView
{
	public class StaggeredGridItemPool
	{
		private GameObject mPrefabObj;

		private string mPrefabName;

		private int mInitCreateCount;

		private float mPadding;

		private List<LoopStaggeredGridViewItem> mTmpPooledItemList;

		private List<LoopStaggeredGridViewItem> mPooledItemList;

		private static int mCurItemIdCount;

		private RectTransform mItemParent;

		public void Init(GameObject prefabObj, float padding, int createCount, RectTransform parent)
		{
		}

		public LoopStaggeredGridViewItem GetItem(int itemIndexForSearch)
		{
			return null;
		}

		public void DestroyAllItem()
		{
		}

		public LoopStaggeredGridViewItem CreateItem()
		{
			return null;
		}

		private void RecycleItemReal(LoopStaggeredGridViewItem item)
		{
		}

		public void RecycleItem(LoopStaggeredGridViewItem item)
		{
		}

		public void ClearTmpRecycledItem()
		{
		}
	}
}
