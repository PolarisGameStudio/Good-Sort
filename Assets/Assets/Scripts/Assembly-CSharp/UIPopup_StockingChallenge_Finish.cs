using System;
using System.Collections.Generic;
using Spine.Unity;
using SuperScrollView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_StockingChallenge_Finish : MonoBehaviour
{
	public static Action OnCloseUI;

	public TextMeshProUGUI txtCurrentScore;

	public RectTransform rectIconReward;

	public SkeletonGraphic[] skeIconRewards;

	public RectTransform rewardHearthInfi;

	public TextMeshProUGUI txtHearthInfi;

	public Button btnClaim;

	public ScrollRect scrollRect;

	public LoopGridView scrollGridView;

	public RectTransform maskRect;

	public UIPopup_StockingChallenge_Item itemMine;

	private List<StockingUser> c_DataStockingUser;

	private bool initScroll;

	private float yScrollRect;

	private List<int> lstIndexStockingUser;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void UpdateUI_Reward()
	{
	}

	private int GetCurrentRank()
	{
		return 0;
	}

	private int GetIndexIconReward(int itemIndex)
	{
		return 0;
	}

	private void UpdateUI_Scroll()
	{
	}

	private LoopGridViewItem InitGridView(LoopGridView view, int itemIndex, int arg3, int arg4)
	{
		return null;
	}

	private void OnValueChangeScrollRect()
	{
	}
}
