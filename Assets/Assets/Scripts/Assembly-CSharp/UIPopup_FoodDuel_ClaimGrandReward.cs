using System;
using Coffee.UIExtensions;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_FoodDuel_ClaimGrandReward : MonoBehaviour
{
	public static Action OnCloseUI;

	public Button btnTapOpenChest;

	public RectTransform rectStep_1;

	public Button btnClaimStep_1;

	public RectTransform rectStep_2;

	public Button btnClaimStep_2;

	[Header("Reward")]
	public SkeletonGraphic[] skeIconChests;

	public float[] scaleIconChests;

	public UIPopup_ListRewards_Item[] itemRewards;

	public UIChest_PatternPositionReward_Item patternPositionReward;

	[Header("Avatar")]
	public RectTransform rectAvatar;

	public RectTransform fxAvatar;

	public Image avatar;

	public UIRect_Profile_FrameAvatar rectFrame;

	public UIParticle fxAvatarDisappear;

	private Vector3 postionSkeIconChestOriginal;

	private void Awake()
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
}
