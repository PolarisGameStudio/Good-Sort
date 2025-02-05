using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_DailyQuest_Item : MonoBehaviour
{
	public Image iconReward;

	public TextMeshProUGUI txtReward;

	public TextMeshProUGUI txtDes;

	public SlicedFilledImage progress;

	public TextMeshProUGUI txtProgress;

	public Button btnGo;

	public Button btnClaim;

	public SkeletonGraphic skeClaimed;

	[Header("Reward Bonus -> Event")]
	public UITag_Digging_RewardBonusAxe rewardDiggingAxe;

	public UITag_MagicCauldron_RewardBonusGift rewardBonusGift;

	public UITag_StallBulding_RewardBonusEnvelope rewardBonusEnvelope;

	public void SetItemData(int index, DailyQuest data)
	{
	}
}
