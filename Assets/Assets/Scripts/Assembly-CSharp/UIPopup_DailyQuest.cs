using System.Collections.Generic;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_DailyQuest : MonoBehaviour
{
	public UIPopup_DailyQuest_Item[] items;

	public Slider progressChest;

	public TextMeshProUGUI txtProgressChest;

	public Button btnSelectChest;

	public SkeletonGraphic skeChest;

	public UITimerCountdownTMP txtTimer;

	[Header("Reward Bonus -> Event")]
	public UITag_Digging_RewardBonusAxe rewardDiggingAxe;

	public UITag_MagicCauldron_RewardBonusGift rewardMagicCauldronGift;

	public UITag_StallBulding_RewardBonusEnvelope rewardBonusEnvelope;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnClaimQuest(List<ResourceValue> reward)
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateUI_ProgressChest()
	{
	}
}
