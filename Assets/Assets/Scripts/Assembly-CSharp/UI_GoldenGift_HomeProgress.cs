using System;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_GoldenGift_HomeProgress : MonoBehaviour
{
	public TextMeshProUGUI textLevelUnlock;

	public GameObject lockContainer;

	public GameObject activeContainer;

	public Button btnOpenUI;

	public Image iconPoint;

	public UIPopup_ListRewards_V2_Item reward;

	public Slider progress;

	public TextMeshProUGUI txtProgress;

	public UITimerCountdownTMP countdown;

	public UI_GoldenGift_HomeProgress_Showcase showcase;

	public UIParticle fxClaimPoint;

	public UIParticle fxClaimReward;

	public static int s_prevPoint;

	public static int s_currentPoint;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateUI_Max()
	{
	}

	private void UpdateUI_Progress_Prev()
	{
	}

	private void UpdateUI_Progress_Current()
	{
	}

	private ResourceValue UpdateUI_BoxReward(int indexReward)
	{
		return null;
	}

	public void TweenProgress(Action<Transform, ResourceValue> onTweenBoxReward, Action onTweenProgressComplete)
	{
	}
}
