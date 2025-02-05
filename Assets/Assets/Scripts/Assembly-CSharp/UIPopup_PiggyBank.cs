using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_PiggyBank : MonoBehaviour
{
	[Header("Progress")]
	public RectTransform fxGold_1;

	public RectTransform fxGold_2;

	public TextMeshProUGUI txtGold_1;

	public TextMeshProUGUI txtGold_2;

	public RectTransform rectNormalProgress;

	public RectTransform rectFullProgress;

	public UITimerCountdownTMP timerFullProgress;

	public Slider progress;

	public TextMeshProUGUI txtSaleOff;

	[Header("Current")]
	public TextMeshProUGUI txtCurrentGold;

	public SkeletonGraphic ske;

	public BoneFollowerGraphic[] boneFollowers;

	[Header("Claim")]
	public Button btnContinue;

	public Button btnClaim;

	public TextMeshProUGUI txtPriceOriginalClaim;

	public TextMeshProUGUI txtPriceClaim;

	private int c_rewardGold;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnBuy()
	{
	}
}
