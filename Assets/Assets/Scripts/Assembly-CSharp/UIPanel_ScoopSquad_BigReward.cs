using System;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_ScoopSquad_BigReward : MonoBehaviour
{
	public static Action OnRefreshUI;

	public static RectTransform s_AvatarGrandReward;

	public Button btnOpenReward;

	public SkeletonGraphic skeIconChest;

	public Image avatarGrandReward;

	public UIRect_Profile_FrameAvatar rectFrameGrandReward;

	public UIPanel_UnlockReward_Info panelInfo;

	public RectTransform rectBtnClaim;

	public Button btnClaim;

	public RectTransform rectClaimed;

	public UIPopup refPopupClaimGrandReward;

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

	private void OnClaimGranReward()
	{
	}

	private void UpdateUI()
	{
	}
}
