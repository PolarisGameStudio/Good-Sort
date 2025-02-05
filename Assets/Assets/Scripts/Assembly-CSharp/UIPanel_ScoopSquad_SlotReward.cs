using System;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_ScoopSquad_SlotReward : MonoBehaviour
{
	public static RectTransform s_RectIconCream;

	public static Action<int, int> OnCloseRewardProgress;

	public Image iconCream;

	public Sprite[] sprIconCreams;

	public RectTransform rectLockUI;

	[Header("Progress Reward")]
	public UIPanel_ScoopSquad_SlotReward_SliderProgress sliderProgress;

	public UIPopup_ListRewards_V2_Item reward_1;

	public Button btnReward_2;

	public Button btnReward_3;

	public RectTransform rectIconComplete_1;

	public RectTransform rectIconComplete_2;

	public RectTransform rectIconComplete_3;

	public UIPanel_UnlockReward_Info refPanelRewardInfo;

	private int c_IndexSlot;

	private float c_RatioLastProgress;

	private void Awake()
	{
	}

	private void OnDestroy()
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

	private void OnSwitchCream(int indexSlot)
	{
	}

	private void OnSpin(int indexSlot, int indexReward)
	{
	}

	private void OnClaimRewardProgress(int indexSlot, int indexReward)
	{
	}

	public void UpdateUI(int indexSlot)
	{
	}

	private void UpdateUI_StateReward(int indexSlot)
	{
	}

	private void CheckCanClaimReward()
	{
	}
}
