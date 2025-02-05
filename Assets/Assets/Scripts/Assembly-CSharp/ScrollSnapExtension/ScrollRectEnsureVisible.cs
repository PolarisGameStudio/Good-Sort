using UnityEngine;
using UnityEngine.UI;

namespace ScrollSnapExtension
{
	[RequireComponent(typeof(ScrollRect))]
	public class ScrollRectEnsureVisible : MonoBehaviour
	{
		private RectTransform _maskTransform;

		private ScrollRect _mScrollRect;

		private RectTransform _mScrollTransform;

		private RectTransform _mContent;

		private void InitScrollRectEnsureVisible()
		{
		}

		public void ForceScrollNormalizedToTarget(RectTransform target)
		{
		}

		public Vector2 GetNormalizedPosition(RectTransform target)
		{
			return default(Vector2);
		}

		private Vector3 GetWidgetWorldPoint(RectTransform target)
		{
			return default(Vector3);
		}

		private Vector3 GetWorldPointInWidget(RectTransform target, Vector3 worldPoint)
		{
			return default(Vector3);
		}
	}
}
