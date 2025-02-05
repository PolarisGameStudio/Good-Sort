using System.Collections.Generic;
using Beardy;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_UnlockReward_Info : MonoBehaviour
{
	public RectTransform rectInfo;

	public CanvasGroup canvasGroupRectInfo;

	public UIContentSizeFitter contentSizeFitter;

	public Beardy.GridLayoutGroup layoutgroup;

	public UIPopup_ListRewards_Item[] items;

	private int c_id;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void UpdateUI(int id, List<ResourceValue> dataReward)
	{
	}

	public void Hide()
	{
	}
}
