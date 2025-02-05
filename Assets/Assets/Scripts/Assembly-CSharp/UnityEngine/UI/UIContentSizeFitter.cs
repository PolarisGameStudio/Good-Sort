using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	public class UIContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		public enum FitMode
		{
			Unconstrained = 0,
			MinSize = 1,
			PreferredSize = 2
		}

		[SerializeField]
		protected FitMode m_HorizontalFit;

		[SerializeField]
		protected FitMode m_VerticalFit;

		private DrivenRectTransformTracker m_Tracker;

		[NonSerialized]
		private RectTransform m_Rect;

		[NonSerialized]
		private RectTransform m_parentRect;

		public bool applyToParent;

		public FitMode horizontalFit
		{
			get
			{
				return default(FitMode);
			}
			set
			{
			}
		}

		public FitMode verticalFit
		{
			get
			{
				return default(FitMode);
			}
			set
			{
			}
		}

		private RectTransform rectTransform => null;

		private RectTransform parentRectTransform => null;

		protected UIContentSizeFitter()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		public virtual void SetLayoutHorizontal()
		{
		}

		public virtual void SetLayoutVertical()
		{
		}

		private void HandleSelfFittingAlongAxis(int axis)
		{
		}

		protected void SetDirty()
		{
		}

		public void ForceSetDirty()
		{
		}
	}
}
