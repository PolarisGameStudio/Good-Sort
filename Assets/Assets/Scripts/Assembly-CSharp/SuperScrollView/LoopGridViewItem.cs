using UnityEngine;

namespace SuperScrollView
{
	public class LoopGridViewItem : MonoBehaviour
	{
		private int mItemIndex;

		private int mRow;

		private int mColumn;

		private int mItemId;

		private LoopGridView mParentGridView;

		private bool mIsInitHandlerCalled;

		private string mItemPrefabName;

		private RectTransform mCachedRectTransform;

		private int mItemCreatedCheckFrameCount;

		private object mUserObjectData;

		private int mUserIntData1;

		private int mUserIntData2;

		private string mUserStringData1;

		private string mUserStringData2;

		private LoopGridViewItem mPrevItem;

		private LoopGridViewItem mNextItem;

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

		public int Row
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Column
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

		public LoopGridView ParentGridView
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LoopGridViewItem PrevItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LoopGridViewItem NextItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
