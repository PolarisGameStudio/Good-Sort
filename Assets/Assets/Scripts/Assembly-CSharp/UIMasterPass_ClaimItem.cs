using System;
using System.Collections.Generic;
using UnityEngine;

public class UIMasterPass_ClaimItem : MonoBehaviour
{
	[Serializable]
	public class Item
	{
		public RectTransform rectBox;

		public UIPopup_ListRewards_Item reward;
	}

	public Item[] items;

	public void Disable()
	{
	}

	public void SetItem(List<ResourceValue> rsValue, Action onComplete)
	{
	}
}
