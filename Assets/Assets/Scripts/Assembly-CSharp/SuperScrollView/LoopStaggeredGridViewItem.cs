using UnityEngine;

namespace SuperScrollView
{
	public class LoopStaggeredGridViewItem : MonoBehaviour
	{
		private int mItemIndex;

		private int mItemIndexInGroup;

		private int mItemId;

		private float mPadding;

		private float mExtraPadding;

		private bool mIsInitHandlerCalled;

		private string mItemPrefabName;

		private RectTransform mCachedRectTransform;

		private LoopStaggeredGridView mParentListView;

		private float mDistanceWithViewPortSnapCenter;

		private int mItemCreatedCheckFrameCount;

		private float mStartPosOffset;

		private object mUserObjectData;

		private int mUserIntData1;

		private int mUserIntData2;

		private string mUserStringData1;

		private string mUserStringData2;

		public object UserObjectData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int UserIntData1
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int UserIntData2
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string UserStringData1
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string UserStringData2
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float DistanceWithViewPortSnapCenter
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StartPosOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int ItemCreatedCheckFrameCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float Padding
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ExtraPadding
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public RectTransform CachedRectTransform => null;

		public string ItemPrefabName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ItemIndexInGroup
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ItemIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ItemId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsInitHandlerCalled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public LoopStaggeredGridView ParentListView
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float TopY => 0f;

		public float BottomY => 0f;

		public float LeftX => 0f;

		public float RightX => 0f;

		public float ItemSize => 0f;

		public float ItemSizeWithPadding => 0f;
	}
}
