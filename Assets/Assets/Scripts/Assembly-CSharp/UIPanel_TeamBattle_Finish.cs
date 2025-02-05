using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_TeamBattle_Finish : MonoBehaviour
{
	public Image iconRankTop3;

	public Sprite[] sprIconRankTop3;

	public RectTransform rectRank;

	public TextMeshProUGUI txtRank;

	public RectTransform rectReward;

	public Image iconReward;

	public Sprite[] sprIconRewards;

	public RectTransform[] fxRankTop3s;

	public RectTransform fxRank;

	public TextMeshProUGUI txtValueReward;

	public RectTransform rectRewardEmpty;

	public RectTransform rectNotGettingReward;

	public RectTransform rectBtnClaim;

	public Button btnClaim;

	public RectTransform rectBtnContinue;

	public Button btnContinue;

	public UIPanel_TimeOutLoading rectLoading;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnConfirmEnd(ResourceValue rewardTeam, ResourceValue rewardIndiviual)
	{
	}

	private void UpdateUI()
	{
	}
}
