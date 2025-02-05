using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SuperScrollView
{
	public class LoopStaggeredGridView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		private Dictionary<string, StaggeredGridItemPool> mItemPoolDict;

		private List<StaggeredGridItemPool> mItemPoolList;

		[SerializeField]
		private List<StaggeredGridItemPrefabConfData> mItemPrefabDataList;

		[SerializeField]
		private ListItemArrangeType mArrangeType;

		private RectTransform mContainerTrans;

		private ScrollRect mScrollRect;

		private int mGroupCount;

		private List<StaggeredGridItemGroup> mItemGroupList;

		private List<ItemIndexData> mItemIndexDataList;

		private RectTransform mScrollRectTransform;

		private RectTransform mViewPortRectTransform;

		private float mItemDefaultWithPaddingSize;

		private int mItemTotalCount;

		private bool mIsVertList;

		private Func<LoopStaggeredGridView, int, LoopStaggeredGridViewItem> mOnGetItemByItemIndex;

		private Func<int, (float, float)> mOnGetItemSizeByItemIndex;

		private Vector3[] mItemWorldCorners;

		private Vector3[] mViewPortRectLocalCorners;

		private float mDistanceForRecycle0;

		private float mDistanceForNew0;

		private float mDistanceForRecycle1;

		private float mDistanceForNew1;

		private bool mIsDraging;

		private PointerEventData mPointerEventData;

		public Action mOnBeginDragAction;

		public Action mOnDragingAction;

		public Action mOnEndDragAction;

		private Vector3 mLastFrameContainerPos;

		private bool mListViewInited;

		private int mListUpdateCheckFrameCount;

		private GridViewLayoutParam mLayoutParam;

		private bool mIsPointerDownInScrollBar;

		private bool mNeedReplaceScrollbarEventHandler;

		private ClickEventListener mScrollBarClickEventListener;

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

		public List<StaggeredGridItemPrefabConfData> ItemPrefabDataList => null;

		public int ListUpdateCheckFrameCount => 0;

		public bool IsVertList => false;

		public int ItemTotalCount => 0;

		public RectTransform ContainerTrans => null;

		public ScrollRect ScrollRect => null;

		public bool IsDraging => false;

		public GridViewLayoutParam LayoutParam => null;

		public bool IsInited => false;

		public float ViewPortSize => 0f;

		public float ViewPortWidth => 0f;

		public float ViewPortHeight => 0f;

		public int CurMaxCreatedItemIndexCount => 0;

		public StaggeredGridItemGroup GetItemGroupByIndex(int index)
		{
			return null;
		}

		public StaggeredGridItemPrefabConfData GetItemPrefabConfData(string prefabName)
		{
			return null;
		}

		public void InitListView(int itemTotalCount, GridViewLayoutParam layoutParam, Func<LoopStaggeredGridView, int, LoopStaggeredGridViewItem> onGetItemByItemIndex, StaggeredGridViewInitParam initParam = null, Func<int, (float, float)> onGetItemSizeByItemIndex = null)
		{
		}

		public void ResetGridViewLayoutParam(int itemTotalCount, GridViewLayoutParam layoutParam)
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

		private void UpdateItemSize()
		{
		}

		private void UpdateLayoutParamAutoValue()
		{
		}

		public LoopStaggeredGridViewItem NewListViewItem(string itemPrefabName)
		{
			return null;
		}

		public void SetListItemCount(int itemCount, bool resetPos = true)
		{
		}

		public void MovePanelToItemIndex(int itemIndex, float offset)
		{
		}

		public LoopStaggeredGridViewItem GetShownItemByItemIndex(int itemIndex)
		{
			return null;
		}

		public void RefreshAllShownItem()
		{
		}

		public void OnItemSizeChanged(int itemIndex)
		{
		}

		public void RefreshItemByItemIndex(int itemIndex)
		{
		}

		public void ResetListView(bool resetPos = true)
		{
		}

		public void UpdateContentSizeUpToItemIndex(int itemIndex)
		{
		}

		public void RecycleAllItem()
		{
		}

		public void RecycleItemTmp(LoopStaggeredGridViewItem item)
		{
		}

		public void ClearAllTmpRecycledItem()
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

		private void SetAnchoredPositionX(RectTransform rtf, float x)
		{
		}

		private void SetAnchoredPositionY(RectTransform rtf, float y)
		{
		}

		public ItemIndexData GetItemIndexData(int itemIndex)
		{
			return null;
		}

		public void UpdateAllGroupShownItemsPos()
		{
		}

		private void CheckAllGroupIfNeedUpdateItemPos()
		{
		}

		public float GetItemAbsPosByItemIndex(int itemIndex)
		{
			return 0f;
		}

		public LoopStaggeredGridViewItem GetNewItemByGroupAndIndex(int groupIndex, int indexInGroup)
		{
			return null;
		}

		private int GetCurShouldAddNewItemGroupIndex()
		{
			return 0;
		}

		public void UpdateListViewWithDefault()
		{
		}

		private void Update()
		{
		}

		public void UpdateListView(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
		}

		public float GetContentSize()
		{
			return 0f;
		}

		public void UpdateContentSize()
		{
		}
	}
}
