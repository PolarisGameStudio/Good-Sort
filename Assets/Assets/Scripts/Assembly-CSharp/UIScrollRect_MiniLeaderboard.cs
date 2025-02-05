using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class UIScrollRect_MiniLeaderboard : MonoBehaviour
{
	public int maxCount;

	public UI_ScrollRectOcclusion scrollRectOcclusion;

	public UIScrollRectSnapToChild scrollRectSnapToChild;

	public ScrollRect scrollRect;

	public RectTransform scrollRectItem;

	public bool initScrollRect;

	public List<RectTransform> mItemNotAssigns;

	public List<RectTransform> mItems;

	public void InitScrollRect(int countDisplay, Action OnExtendSetListItem = null)
	{
	}

	public void SnapScrollToChild(int index, float duration = 0f)
	{
	}

	public void SwapCurrentItemToHigher(int indexCurrent, int indexTarget)
	{
	}
}
