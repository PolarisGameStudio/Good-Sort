using System;
using UnityEngine;
using UnityEngine.UI;

public class UILeaderboard_NavType : MonoBehaviour
{
	public CanvasGroup viewport;

	public Button[] btnTabs;

	public Image[] iconBtnTabs;

	public Sprite[] sprStates;

	public void UpdateUI(Action<int> onClickTab)
	{
	}

	public void ForceOpenTab(int index)
	{
	}
}
