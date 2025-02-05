using System;
using UnityEngine;

public class UIRect_Profile_Badge : MonoBehaviour
{
	[Serializable]
	public class BadgeById
	{
		public int id;

		public RectTransform rectBadge;

		public void Disable()
		{
		}

		public void Active(int index)
		{
		}
	}

	public BadgeById[] badges;

	public void UpdateUI(int indexBadge)
	{
	}
}
