using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class LoopListView2 : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		private class SnapData
		{
			public SnapStatus mSnapStatus;

			public int mSnapTargetIndex;

			public float mTargetSnapVal;

			public float mCurSnapVal;

			public bool mIsForceSnapTo;

			public bool mIsTempTarget;

			public int mTempTargetIndex;

			public float mMoveMaxAbsVec;

			public void Clear()
			{
			}
		}

		private Dictionary<string, ItemPool> mItemPoolDict;

		private List<ItemPool> mItemPoolList;

		[SerializeField]
		private List<ItemPrefabConfData> mItemPrefabDataList;

		[SerializeField]
		private ListItemArrangeType mArrangeType;

		private List<LoopListViewItem2> mItemList;

		private RectTransform mContainerTrans;

		private ScrollRect mScrollRect;

		private RectTransform mScrollRectTransform;

		private RectTransform mViewPortRectTransform;

		private float mItemDefaultWithPaddingSize;

		private int mItemTotalCount;

		private bool mIsVertList;

		private Func<LoopListView2, int, LoopListViewItem2> mOnGetItemByIndex;

		private Vector3[] mItemWorldCorners;

		private Vector3[] mViewPortRectLocalCorners;

		private int mCurReadyMinItemIndex;

		private int mCurReadyMaxItemIndex;

		private bool mNeedCheckNextMinItem;

		private bool mNeedCheckNextMaxItem;

		private ItemPosMgr mItemPosMgr;

		private float mDistanceForRecycle0;

		private float mDistanceForNew0;

		private float mDistanceForRecycle1;

		private float mDistanceForNew1;

		[SerializeField]
		private bool mSupportScrollBar;

		private bool mIsDraging;

		private PointerEventData mPointerEventData;

		public Action mOnBeginDragAction;

		public Action mOnDragingAction;

		public Action mOnEndDragAction;

		private int mLastItemIndex;

		private float mLastItemPadding;

		private float mSmoothDumpVel;

		private float mSmoothDumpRate;

		private float mSnapFinishThreshold;

		private float mSnapVecThreshold;

		private float mSnapMoveDefaultMaxAbsVec;

		[SerializeField]
		private bool mItemSnapEnable;

		private Vector3 mLastFrameContainerPos;

		public Action<LoopListView2, LoopListViewItem2> mOnSnapItemFinished;

		public Action<LoopListView2, LoopListViewItem2> mOnSnapNearestChanged;

		private int mCurSnapNearestItemIndex;

		private Vector2 mAdjustedVec;

		private bool mNeedAdjustVec;

		private int mLeftSnapUpdateExtraCount;

		[SerializeField]
		private Vector2 mViewPortSnapPivot;

		[SerializeField]
		private Vector2 mItemSnapPivot;

		private ClickEventListener mScrollBarClickEventListener;

		private SnapData mCurSnapData;

		private Vector3 mLastSnapCheckPos;

		private bool mListViewInited;

		private int mListUpdateCheckFrameCount;

		public Action<LoopListView2> OnListViewStart;

		private bool mIsPointerDownInScrollBar;

		private bool mNeedReplaceScrollbarEventHandler;

		private int mCurCreatingItemIndex;

		public ListItemArrangeType ArrangeType
		{
			get
			{
				return default(ListItemArrangeType);
			}
			set
			{
			}
		}

		public List<ItemPrefabConfData> ItemPrefabDataList => null;

		public List<LoopListViewItem2> ItemList => null;

		public bool IsVertList => false;

		public int ItemTotalCount => 0;

		public RectTransform ContainerTrans => null;

		public RectTransform ViewPortTrans => null;

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

		public bool SupportScrollBar
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float SnapMoveDefaultMaxAbsVec
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int ShownItemCount => 0;

		public float ViewPortSize => 0f;

		public float ViewPortWidth => 0f;

		public float ViewPortHeight => 0f;

		public int CurSnapNearestItemIndex => 0;

		public ItemPrefabConfData GetItemPrefabConfData(string prefabName)
		{
			return null;
		}

		public void OnItemPrefabChanged(string prefabName)
		{
		}

		public void InitListView(int itemTotalCount, Func<LoopListView2, int, LoopListViewItem2> onGetItemByIndex, LoopListViewInitParam initParam = null)
		{
		}

		private void Start()
		{
		}

		private void SetScrollbarListener()
		{
		}

		private void OnPointerDownInScrollBar(GameObject obj)
		{
		}

		private void OnPointerUpInScrollBar(GameObject obj)
		{
		}

		private void ReplaceScrollbarEventHandlerForSmoothMove()
		{
		}

		private void OnScrollBarValueChanged(float value)
		{
		}

		public void ResetListView(bool resetPos = true)
		{
		}

		public void SetListItemCount(int itemCount, bool resetPos = true)
		{
		}

		public LoopListViewItem2 GetShownItemByItemIndex(int itemIndex)
		{
			return null;
		}

		public LoopListViewItem2 GetShownItemByItemId(int itemId)
		{
			return null;
		}

		public LoopListViewItem2 GetShownItemNearestItemIndex(int itemIndex)
		{
			return null;
		}

		public LoopListViewItem2 GetShownItemByIndex(int index)
		{
			return null;
		}

		public void SetShownItemByIndex(int index, LoopListViewItem2 item)
		{
		}

		public LoopListViewItem2 GetShownItemByIndexWithoutCheck(int index)
		{
			return null;
		}

		public int GetIndexInShownItemList(LoopListViewItem2 item)
		{
			return 0;
		}

		public void DoActionForEachShownItem(Action<LoopListViewItem2, object> action, object param)
		{
		}

		public LoopListViewItem2 NewListViewItem(string itemPrefabName)
		{
			return null;
		}

		public void OnItemSizeChanged(int itemIndex)
		{
		}

		public void RefreshItemByItemIndex(int itemIndex)
		{
		}

		public void FinishSnapImmediately()
		{
		}

		public void MovePanelToItemIndex(int itemIndex, float offset)
		{
		}

		public void RefreshAllShownItem()
		{
		}

		public void MovePanelByOffset(float offset)
		{
		}

		public ItemPosStruct GetFirstShownItemIndexAndOffset()
		{
			return default(ItemPosStruct);
		}

		public void RefreshAllShownItemWithFirstIndex(int firstItemIndex)
		{
		}

		public void RefreshAllShownItemWithFirstIndexAndPos(int firstItemIndex, Vector3 pos)
		{
		}

		public void RecycleItemImmediately(LoopListViewItem2 item)
		{
		}

		private void RecycleItemTmp(LoopListViewItem2 item)
		{
		}

		private void ClearAllTmpRecycledItem()
		{
		}

		private void RecycleAllItem()
		{
		}

		private void AdjustContainerPivot(RectTransform rtf)
		{
		}

		private void AdjustPivot(RectTransform rtf)
		{
		}

		private void AdjustContainerAnchor(RectTransform rtf)
		{
		}

		private void AdjustAnchor(RectTransform rtf)
		{
		}

		private void InitItemPool()
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

		private void CacheDragPointerEventData(PointerEventData eventData)
		{
		}

		private LoopListViewItem2 GetNewItemByIndex(int index)
		{
			return null;
		}

		private void SetItemSize(int itemIndex, float itemSize, float padding)
		{
		}

		private bool GetPlusItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos)
		{
			return false;
		}

		private float GetItemPos(int itemIndex)
		{
			return 0f;
		}

		public Vector3 GetItemCornerPosInViewPort(LoopListViewItem2 item, ItemCornerEnum corner = ItemCornerEnum.LeftBottom)
		{
			return default(Vector3);
		}

		private void AdjustPanelPos()
		{
		}

		private void Update()
		{
		}

		private void UpdateSnapMove(bool immediate = false, bool forceSendEvent = false)
		{
		}

		public void UpdateAllShownItemSnapData()
		{
		}

		private void UpdateSnapVertical(bool immediate = false, bool forceSendEvent = false)
		{
		}

		private void UpdateCurSnapData()
		{
		}

		public void ClearSnapData()
		{
		}

		public void SetSnapTargetItemIndex(int itemIndex, float moveMaxAbsVec = -1f)
		{
		}

		public void ForceSnapUpdateCheck()
		{
		}

		private void UpdateSnapHorizontal(bool immediate = false, bool forceSendEvent = false)
		{
		}

		private bool CanSnap()
		{
			return false;
		}

		private void SetAnchoredPositionX(RectTransform rtf, float x)
		{
		}

		private void SetAnchoredPositionY(RectTransform rtf, float y)
		{
		}

		public void UpdateListView(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
		}

		private bool UpdateForVertList(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return false;
		}

		private bool UpdateForHorizontalList(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return false;
		}

		private float GetContentPanelSize()
		{
			return 0f;
		}

		private void CheckIfNeedUpdataItemPos()
		{
		}

		private void UpdateAllShownItemsPos()
		{
		}

		private void UpdateContentSize()
		{
		}
	}
}
