using System;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_StallBuilding_DecorationOptions_Item : MonoBehaviour
{
	public CanvasGroup canvasGroup;

	public RectTransform rectPreview;

	public SkeletonGraphic skeLock;

	public Button btnSelect;

	public RectTransform rectBuy;

	public Button btnBuy;

	public TextMeshProUGUI txtPriceBuy;

	public RectTransform rectSelected;

	public void TweenIn(int itemIndex)
	{
	}

	public void SetItemData(int decorIndex, int itemIndex)
	{
	}

	public void PreUnlock()
	{
	}

	public void Unlock(Action OnComplete)
	{
	}
}
