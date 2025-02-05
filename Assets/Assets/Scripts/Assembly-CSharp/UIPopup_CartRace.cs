using System;
using Coffee.UIExtensions;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_CartRace : MonoBehaviour
{
	[Serializable]
	public class EndEvent_ShowChestReward
	{
		[Header("My Reward")]
		public RectTransform rectMyReward;

		public Button btnChest;

		public SkeletonGraphic skeIconChest;

		public Button btnClaim;

		public RectTransform rectComplete;

		[Header("Can Claim")]
		public RectTransform[] rectCanClaims;

		public Button[] btnChestCanClaims;

		public SkeletonGraphic[] skeIconChestCanClaims;

		public UIParticle[] fxCompleteRuns;

		private string GetSkinNameChest(int rank)
		{
			return null;
		}

		public void TweenIn_MyReward()
		{
		}

		public void TweenIn_Reward(int indexPlayer)
		{
		}

		public void UpdateUI_MyReward(UIPopup_CartRace refManager, int rank)
		{
		}

		public void UpdateUI(UIPopup_CartRace refManager, int indexPlayer, int rank)
		{
		}

		public void CloseUI()
		{
		}
	}

	public static Action OnCloseUI;

	public Button btnHelp;

	public UIPopup popupHelp;

	public RectTransform rectBtnPlay;

	public Button btnPlay;

	public TextMeshProUGUI txtPlay;

	[Header("Race")]
	public UITimerCountdownTMP timer;

	public TextMeshProUGUI txtDescription;

	public HorizontalLayoutGroup[] rectBGLands;

	public UICartRace_Player_Item[] items;

	[Header("Reward")]
	public EndEvent_ShowChestReward endEventShowChestReward;

	public UIPanel_UnlockReward_Info bubbleRewardChest;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void UpdateUI()
	{
	}

	public void UpdateUI_Register()
	{
	}
}
