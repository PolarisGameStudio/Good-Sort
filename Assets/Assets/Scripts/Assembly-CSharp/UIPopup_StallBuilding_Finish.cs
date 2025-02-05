using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_StallBuilding_Finish : MonoBehaviour
{
	public RectTransform[] rectWinners;

	public RectTransform[] rectLosers;

	public TextMeshProUGUI txtDes;

	public Image iconRankTop3;

	public Sprite[] sprIconRankTop3;

	public RectTransform rectRank;

	public TextMeshProUGUI txtRank;

	public RectTransform[] fxRankTop3s;

	public RectTransform fxRank;

	public RectTransform rectReward;

	public Image iconReward;

	public TextMeshProUGUI txtValueReward;

	public Sprite[] sprIconRewards;

	public RectTransform rewardEmpty;

	public RectTransform rectBtnClaim;

	public Button btnClaim;

	public RectTransform rectBtnContinue;

	public Button btnContinue;

	public void UpdateUI(int currentLeaderboardRank)
	{
	}
}
