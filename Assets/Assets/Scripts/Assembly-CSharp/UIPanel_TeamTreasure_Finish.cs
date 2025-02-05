using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_TeamTreasure_Finish : MonoBehaviour
{
	public Image iconRankTop3;

	public Sprite[] sprIconRankTop3;

	public RectTransform rectRank;

	public TextMeshProUGUI txtRank;

	public RectTransform[] fxRankTop3s;

	public RectTransform fxRank;

	public UIPopup_ListRewards_V2_Item reward;

	public RectTransform rewardEmpty;

	public Button btnFinish;

	public UIPanel_TimeOutLoading rectLoading;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnConfirmEnd(List<ResourceValue> dataReward)
	{
	}

	private void UpdateUI()
	{
	}

	private void ClaimRewardByRank()
	{
	}
}
