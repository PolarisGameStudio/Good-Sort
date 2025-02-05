using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SuperScrollView
{
	public class ClickEventListener : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
	{
		private Action<GameObject> mClickedHandler;

		private Action<GameObject> mDoubleClickedHandler;

		private Action<GameObject> mOnPointerDownHandler;

		private Action<GameObject> mOnPointerUpHandler;

		private bool mIsPressed;

		public bool IsPressd => false;

		public static ClickEventListener Get(GameObject obj)
		{
			return null;
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void SetClickEventHandler(Action<GameObject> handler)
		{
		}

		public void SetDoubleClickEventHandler(Action<GameObject> handler)
		{
		}

		public void SetPointerDownHandler(Action<GameObject> handler)
		{
		}

		public void SetPointerUpHandler(Action<GameObject> handler)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}
	}
}
