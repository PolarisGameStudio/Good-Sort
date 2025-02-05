using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_FoodDuel_Finish : MonoBehaviour
{
	public static RectTransform s_rectBtnInfoReward;

	public RectTransform[] rectWinners;

	public RectTransform[] rectLosers;

	public TextMeshProUGUI txtDes;

	public Image iconRankTop3;

	public Sprite[] sprIconRankTop3;

	public RectTransform rectRank;

	public TextMeshProUGUI txtRank;

	public RectTransform[] fxRankTop3s;

	public RectTransform fxRank;

	public Button btnInfoReward;

	public SkeletonGraphic[] skeChests;

	public UIPanel_UnlockReward_Info panelInfoReward;

	public RectTransform rewardEmpty;

	public RectTransform rectBtnClaim;

	public Button btnClaim;

	public RectTransform rectBtnContinue;

	public Button btnContinue;

	public RectTransform rectLoading;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnClaimLeaderboardReward(int obj)
	{
	}

	private void UpdateUI()
	{
	}
}
