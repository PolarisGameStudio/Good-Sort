using System.Collections.Generic;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIEndlessPack_V3_RewardProgress : MonoBehaviour
{
	public UIPopup refPopupClaimProgressReward;

	public RectTransform rectPointTarget;

	public UIParticle fxIconPointTarget;

	public Slider slider;

	public UIEndlessPack_V3_RewardProgress_Item[] rewards;

	[Header("Reward Fly")]
	public RectTransform rectBoxRewardFly;

	public Image iconRewardFly;

	public TextMeshProUGUI txtRewardFly;

	private List<(int ProgressNeeded, float StartValue, float EndValue)> listProgressNeedUpdates;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnClaimByWine(int indexReward)
	{
	}

	private void OnClaim(int indexReward)
	{
	}

	private void UpdateUI()
	{
	}

	private float GetRealProgress(int CurrentProgress)
	{
		return 0f;
	}
}
