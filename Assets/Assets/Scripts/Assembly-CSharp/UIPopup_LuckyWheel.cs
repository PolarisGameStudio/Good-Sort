using System.Collections.Generic;
using Coffee.UIExtensions;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_LuckyWheel : MonoBehaviour
{
	public Button btnExit;

	public UITimerCountdownTMP timer;

	public Button btnSpin;

	public RectTransform[] rectStateSpins;

	public TextMeshProUGUI txtNumberLeft;

	public TextMeshProUGUI[] txtValueRewards;

	public RectTransform[] rectImageRewards;

	public UIParticle[] fxWheelSpineDones;

	public UIParticle _fxReward;

	public RectTransform rectItemRewardFly;

	public UIPopup_ListRewards_Item itemRewardFly;

	public RectTransform rectLockUI;

	[Header("Reward Bonus -> Event")]
	public UITag_Digging_RewardBonusAxe[] rewardDiggingAxes;

	public UITag_MagicCauldron_RewardBonusGift[] rewardBonusGifts;

	public UITag_StallBulding_RewardBonusEnvelope[] rewardBonusEnvelopes;

	[Header("Wheel")]
	public RectTransform rectBGWheel;

	public RectTransform wheel;

	public float spinDuration;

	public int minSpins;

	public AnimationCurve curve;

	public SkeletonGraphic skelWheelDetail;

	public UIParticle _wheelLight;

	public UIParticle _wheelLightActive;

	public UIParticle _wheelCore;

	private bool c_IsSpinning;

	private TextMeshProUGUI c_TextRewardSelected;

	private RectTransform c_RectImageRewardSelected;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSpin(int index, List<ResourceValue> reward)
	{
	}

	private void UpdateUI()
	{
	}

	private void StartSpin(int indexReward, List<ResourceValue> rewards)
	{
	}

	private void FXStartSpin()
	{
	}

	private void FXStopSpin()
	{
	}
}
