using System;
using UnityEngine;

public class UIRect_Profile_FrameAvatar : MonoBehaviour
{
	[Serializable]
	public class FrameById
	{
		public int id;

		public RectTransform rectFrame;

		public void Disable()
		{
		}

		public void Active(int index)
		{
		}
	}

	[SerializeField]
	private FrameById[] _frames;

	public void UpdateUI(int id)
	{
	}
}
