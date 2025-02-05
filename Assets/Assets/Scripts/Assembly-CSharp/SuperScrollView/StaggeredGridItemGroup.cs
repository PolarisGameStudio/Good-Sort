using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class StaggeredGridItemGroup
	{
		private LoopStaggeredGridView mParentGridView;

		private ListItemArrangeType mArrangeType;

		private List<LoopStaggeredGridViewItem> mItemList;

		private RectTransform mContainerTrans;

		private ScrollRect mScrollRect;

		public int mGroupIndex;

		private GameObject mGameObject;

		private List<int> mItemIndexMap;

		private RectTransform mScrollRectTransform;

		private RectTransform mViewPortRectTransform;

		private float mItemDefaultWithPaddingSize;

		private int mItemTotalCount;

		private bool mIsVertList;

		private Func<int, int, LoopStaggeredGridViewItem> mOnGetItemByIndex;

		private Vector3[] mItemWorldCorners;

		private Vector3[] mViewPortRectLocalCorners;

		private int mCurReadyMinItemIndex;

		private int mCurReadyMaxItemIndex;

		private bool mNeedCheckNextMinItem;

		private bool mNeedCheckNextMaxItem;

		private ItemPosMgr mItemPosMgr;

		private bool mSupportScrollBar;

		private int mLastItemIndex;

		private float mLastItemPadding;

		private Vector3 mLastFrameContainerPos;

		private int mListUpdateCheckFrameCount;

		public List<int> ItemIndexMap => null;

		public float ViewPortSize => 0f;

		public float ViewPortWidth => 0f;

		public float ViewPortHeight => 0f;

		private bool IsDraging => false;

		public int HadCreatedItemCount => 0;

		public void Init(LoopStaggeredGridView parent, int itemTotalCount, int groupIndex, Func<int, int, LoopStaggeredGridViewItem> onGetItemByIndex)
		{
		}

		public void ResetListView()
		{
		}

		public LoopStaggeredGridViewItem GetShownItemByItemIndex(int itemIndex)
		{
			return null;
		}

		public LoopStaggeredGridViewItem GetShownItemByIndexInGroup(int indexInGroup)
		{
			return null;
		}

		public int GetIndexInShownItemList(LoopStaggeredGridViewItem item)
		{
			return 0;
		}

		public void RefreshAllShownItem()
		{
		}

		public void OnItemSizeChanged(int indexInGroup)
		{
		}

		public void RefreshItemByIndexInGroup(int indexInGroup)
		{
		}

		public void RefreshAllShownItemWithFirstIndexInGroup(int firstItemIndexInGroup)
		{
		}

		public void RefreshAllShownItemWithFirstIndexAndPos(int firstItemIndexInGroup, Vector3 pos)
		{
		}

		public void SetItemSize(int itemIndex, float itemSize, float padding)
		{
		}

		private bool GetPlusItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos)
		{
			return false;
		}

		public float GetItemPos(int itemIndex)
		{
			return 0f;
		}

		public Vector3 GetItemCornerPosInViewPort(LoopStaggeredGridViewItem item, ItemCornerEnum corner = ItemCornerEnum.LeftBottom)
		{
			return default(Vector3);
		}

		public void RecycleItemTmp(LoopStaggeredGridViewItem item)
		{
		}

		public void RecycleAllItem()
		{
		}

		public void ClearAllTmpRecycledItem()
		{
		}

		private LoopStaggeredGridViewItem GetNewItemByIndexInGroup(int indexInGroup)
		{
			return null;
		}

		public void SetListItemCount(int itemCount)
		{
		}

		private void UpdateItemIndexMap(int oldItemTotalCount)
		{
		}

		public void UpdateListViewPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
		}

		public bool UpdateListViewPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return false;
		}

		public bool UpdateForVertListPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return false;
		}

		public bool UpdateForVertListPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return false;
		}

		public bool UpdateForHorizontalListPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return false;
		}

		public bool UpdateForHorizontalListPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return false;
		}

		public float GetContentPanelSize()
		{
			return 0f;
		}

		public float GetContentPanelSizeWithLastItemPadding()
		{
			return 0f;
		}

		public float GetShownItemPosMaxValue()
		{
			return 0f;
		}

		public void CheckIfNeedUpdateItemPos()
		{
		}

		public void UpdateAllShownItemsPos()
		{
		}
	}
}
