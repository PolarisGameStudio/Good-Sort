using System;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_ListRewards : MonoBehaviour
{
	public TextMeshProUGUI txtTitle;

	public TextMeshProUGUI txtDescription;

	public UIContentSizeFitter fitterReward;

	public UIPopup_ListRewards_Item[] items;

	public CanvasGroup canvasGroupReward;

	public Button btnTap;

	public TextMeshProUGUI txtTap;

	public DOTweenAnimation[] tweenRectTransforms;

	private WaitForSeconds waitItem;

	public void UpdateUI_Title(string strTitle, string strDescription)
	{
	}

	public void UpdateUI(List<ResourceValue> dataReward)
	{
	}

	private List<List<ResourceValue>> SplitList(List<ResourceValue> originalList, int sublistSize)
	{
		return null;
	}

	public static void OpenUI(string title, string description, List<ResourceValue> dataReward, Action onCloseUI = null)
	{
	}
}
