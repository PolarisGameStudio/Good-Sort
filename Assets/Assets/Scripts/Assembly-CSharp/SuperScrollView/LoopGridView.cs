using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class LoopGridView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		private class SnapData
		{
			public SnapStatus mSnapStatus;

			public RowColumnPair mSnapTarget;

			public Vector2 mSnapNeedMoveDir;

			public float mTargetSnapVal;

			public float mCurSnapVal;

			public bool mIsForceSnapTo;

			public void Clear()
			{
			}
		}

		private class ItemRangeData
		{
			public int mMaxRow;

			public int mMinRow;

			public int mMaxColumn;

			public int mMinColumn;

			public Vector2 mCheckedPosition;
		}

		private Dictionary<string, GridItemPool> mItemPoolDict;

		private List<GridItemPool> mItemPoolList;

		[SerializeField]
		private List<GridViewItemPrefabConfData> mItemPrefabDataList;

		[SerializeField]
		private GridItemArrangeType mArrangeType;

		private RectTransform mContainerTrans;

		private ScrollRect mScrollRect;

		private RectTransform mScrollRectTransform;

		private RectTransform mViewPortRectTransform;

		private int mItemTotalCount;

		[SerializeField]
		private int mFixedRowOrColumnCount;

		[SerializeField]
		private RectOffset mPadding;

		[SerializeField]
		private Vector2 mItemPadding;

		[SerializeField]
		private Vector2 mItemSize;

		[SerializeField]
		private Vector2 mItemRecycleDistance;

		private Vector2 mItemSizeWithPadding;

		private Vector2 mStartPadding;

		private Vector2 mEndPadding;

		private Func<LoopGridView, int, int, int, LoopGridViewItem> mOnGetItemByRowColumn;

		private List<GridItemGroup> mItemGroupObjPool;

		private List<GridItemGroup> mItemGroupList;

		private bool mIsDraging;

		private int mRowCount;

		private int mColumnCount;

		public Action<PointerEventData> mOnBeginDragAction;

		public Action<PointerEventData> mOnDragingAction;

		public Action<PointerEventData> mOnEndDragAction;

		private float mSmoothDumpVel;

		private float mSmoothDumpRate;

		private float mSnapFinishThreshold;

		private float mSnapVecThreshold;

		[SerializeField]
		private bool mItemSnapEnable;

		[SerializeField]
		private GridFixedType mGridFixedType;

		public Action<LoopGridView, LoopGridViewItem> mOnSnapItemFinished;

		public Action<LoopGridView> mOnSnapNearestChanged;

		private int mLeftSnapUpdateExtraCount;

		[SerializeField]
		private Vector2 mViewPortSnapPivot;

		[SerializeField]
		private Vector2 mItemSnapPivot;

		private SnapData mCurSnapData;

		private Vector3 mLastSnapCheckPos;

		private bool mListViewInited;

		private int mListUpdateCheckFrameCount;

		private ItemRangeData mCurFrameItemRangeData;

		private int mNeedCheckContentPosLeftCount;

		private ClickEventListener mScrollBarClickEventListener1;

		private ClickEventListener mScrollBarClickEventListener2;

		private RowColumnPair mCurSnapNearestItemRowColumn;

		private bool mIsPointerDownInVerticalScrollBar;

		private bool mIsPointerDownInHorizontalScrollBar;

		private bool mNeedReplaceScrollbarEventHandler;

		private int mCurCreatingItemIndex;

		public GridItemArrangeType ArrangeType
		{
			get
			{
				return default(GridItemArrangeType);
			}
			set
			{
			}
		}

		public List<GridViewItemPrefabConfData> ItemPrefabDataList => null;

		public int ItemTotalCount => 0;

		public RectTransform ContainerTrans => null;

		public float ViewPortWidth => 0f;

		public float ViewPortHeight => 0f;

		public ScrollRect ScrollRect => null;

		public bool IsDraging => false;

		public bool ItemSnapEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector2 ItemSize
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 ItemPadding
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 ItemSizeWithPadding => default(Vector2);

		public RectOffset Padding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RowColumnPair CurSnapNearestItemRowColumn => default(RowColumnPair);

		public GridViewItemPrefabConfData GetItemPrefabConfData(string prefabName)
		{
			return null;
		}

		public void InitGridView(int itemTotalCount, Func<LoopGridView, int, int, int, LoopGridViewItem> onGetItemByRowColumn, LoopGridViewSettingParam settingParam = null, LoopGridViewInitParam initParam = null)
		{
		}

		public void SetListItemCount(int itemCount, bool resetPos = true)
		{
		}

		public LoopGridViewItem NewListViewItem(string itemPrefabName)
		{
			return null;
		}

		public void ClearAllShownItems()
		{
		}

		public void RefreshItemByItemIndex(int itemIndex)
		{
		}

		public void RefreshItemByRowColumn(int row, int column)
		{
		}

		public void ClearSnapData()
		{
		}

		public void SetSnapTargetItemRowColumn(int row, int column)
		{
		}

		public void ForceSnapUpdateCheck()
		{
		}

		public void ForceToCheckContentPos()
		{
		}

		public void MovePanelToItemByIndex(int itemIndex, float offsetX = 0f, float offsetY = 0f)
		{
		}

		public void MovePanelToItemByRowColumn(int row, int column, float offsetX = 0f, float offsetY = 0f)
		{
		}

		public void RefreshAllShownItem()
		{
		}

		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		public int GetItemIndexByRowColumn(int row, int column)
		{
			return 0;
		}

		public RowColumnPair GetRowColumnByItemIndex(int itemIndex)
		{
			return default(RowColumnPair);
		}

		public Vector2 GetItemAbsPos(int row, int column)
		{
			return default(Vector2);
		}

		public Vector2 GetItemPos(int row, int column)
		{
			return default(Vector2);
		}

		public LoopGridViewItem GetShownItemByItemIndex(int itemIndex)
		{
			return null;
		}

		public LoopGridViewItem GetShownItemByRowColumn(int row, int column)
		{
			return null;
		}

		public void UpdateAllGridSetting()
		{
		}

		public void SetGridFixedGroupCount(GridFixedType fixedType, int count)
		{
		}

		public void SetItemSize(Vector2 newSize)
		{
		}

		public void SetItemPadding(Vector2 newPadding)
		{
		}

		public void SetPadding(RectOffset newPadding)
		{
		}

		public void UpdateContentSize()
		{
		}

		public void VaildAndSetContainerPos()
		{
		}

		public void ClearAllTmpRecycledItem()
		{
		}

		public void RecycleAllItem()
		{
		}

		public void UpdateGridViewContent()
		{
		}

		public void UpdateStartEndPadding()
		{
		}

		public void UpdateItemSize()
		{
		}

		public void UpdateColumnRowCount()
		{
		}

		private bool IsContainerTransCanMove()
		{
			return false;
		}

		private void RecycleItemGroupTmp(GridItemGroup group)
		{
		}

		private void RecycleItemTmp(LoopGridViewItem item)
		{
		}

		private void AdjustViewPortPivot()
		{
		}

		private void AdjustContainerAnchorAndPivot()
		{
		}

		private void AdjustItemAnchorAndPivot(RectTransform rtf)
		{
		}

		private void InitItemPool()
		{
		}

		private LoopGridViewItem GetNewItemByRowColumn(int row, int column)
		{
			return null;
		}

		private RowColumnPair GetCeilItemRowColumnAtGivenAbsPos(float ax, float ay)
		{
			return default(RowColumnPair);
		}

		private void Update()
		{
		}

		private GridItemGroup CreateItemGroup(int groupIndex)
		{
			return null;
		}

		private Vector2 GetContainerMovedDistance()
		{
			return default(Vector2);
		}

		private Vector2 GetContainerVaildPos(float curX, float curY)
		{
			return default(Vector2);
		}

		private void UpdateCurFrameItemRangeData()
		{
		}

		private void UpdateRowItemGroupForRecycleAndNew(GridItemGroup group)
		{
		}

		private void UpdateColumnItemGroupForRecycleAndNew(GridItemGroup group)
		{
		}

		private void SetScrollbarListener()
		{
		}

		private void ReplaceScrollbarEventHandlerForSmoothMove()
		{
		}

		private void OnVerticalScrollBarValueChanged(float value)
		{
		}

		private void OnHorizontalScrollBarValueChanged(float value)
		{
		}

		private void OnPointerDownInVerticalScrollBar(GameObject obj)
		{
		}

		private void OnPointerUpInVerticalScrollBar(GameObject obj)
		{
		}

		private void OnPointerDownInHorizontalScrollBar(GameObject obj)
		{
		}

		private void OnPointerUpInHorizontalScrollBar(GameObject obj)
		{
		}

		private RowColumnPair FindNearestItemWithLocalPos(float x, float y)
		{
			return default(RowColumnPair);
		}

		private Vector2 GetItemSnapPivotLocalPos(int row, int column)
		{
			return default(Vector2);
		}

		private Vector2 GetViewPortSnapPivotLocalPos(Vector2 pos)
		{
			return default(Vector2);
		}

		private void UpdateNearestSnapItem(bool forceSendEvent)
		{
		}

		private void UpdateFromSettingParam(LoopGridViewSettingParam param)
		{
		}

		public void FinishSnapImmediately()
		{
		}

		private void UpdateSnapMove(bool immediate = false, bool forceSendEvent = false)
		{
		}

		private GridItemGroup GetShownGroup(int groupIndex)
		{
			return null;
		}

		private void FillCurSnapData(int row, int column)
		{
		}

		private void UpdateCurSnapData()
		{
		}

		private bool CanSnap()
		{
			return false;
		}

		private GridItemGroup GetOneItemGroupObj()
		{
			return null;
		}

		private void RecycleOneItemGroupObj(GridItemGroup obj)
		{
		}
	}
}
