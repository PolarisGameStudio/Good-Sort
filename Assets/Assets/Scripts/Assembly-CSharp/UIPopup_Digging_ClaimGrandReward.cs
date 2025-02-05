using System;
using Coffee.UIExtensions;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Digging_ClaimGrandReward : MonoBehaviour
{
	public static Action OnCloseUI;

	public Button btnTapOpenChest;

	public RectTransform rectStep_1;

	public Button btnClaimStep_1;

	public RectTransform rectStep_2;

	public Button btnClaimStep_2;

	[Header("Reward")]
	public SkeletonGraphic skeIconChest;

	public UIPopup_ListRewards_Item[] itemRewards;

	private Vector3[] anchorPosOriginalItemRewards;

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
