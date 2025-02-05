using System;
using Coffee.UIExtensions;
using DG.Tweening;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Digging : MonoBehaviour
{
	public static Action OnCloseUI;

	public static Action OnReadyAxeDigComplete;

	public static Action OnAxeDigComplete;

	public static Action<ItemInBoard> OnClaimItemInMapTile;

	public static Action OnReadySwitchLevel;

	public static Action OnSwitchLevel;

	private static Action<int, Action> OnForceClaimProgressReward;

	public Button btnExit;

	public DOTweenAnimation tweenRectLayerMaps;

	public RectTransform rectLayerMaps;

	public RectTransform rectLayerMap_1;

	public RectTransform rectLayerMap_2;

	public RectTransform rectLevelsReadyToPlay;

	public UIPanel_Digging_Level[] rectLevels;

	public RectTransform rectCompleteLastLevel;

	public UIPopup popupConfirmExit;

	public Button btnHelp;

	public UIPopup popupHelp;

	[Header("Lock UI")]
	public RectTransform rectLockUIUseAxe;

	public RectTransform rectLockUIClaimItemInMapTile;

	public RectTransform rectLockUISwitchLevel;

	[Header("Axe")]
	public SkeletonGraphic skeAxe;

	public UIParticle fxUseAxeNormal;

	public UIParticle fxUseAxeSuper;

	public RectTransform rectIconRewardAxeTile;

	public TextMeshProUGUI txtRewardAxeTile;

	public UIPopup_ListRewards_Item itemRewardBonusTile;

	public UIParticle fxClaimItemRewardBonusTile;

	[Header("Popup Reward")]
	public UIPopup popupClaimNormalReward;

	public UIPopup popupClaimGrandReward;

	[Header("Do not assign")]
	public UIPanel_Digging_Level rectCurrentLevel;

	public UIPanel_Digging_Level rectNextLevel;

	private Vector3 c_ScaleLevelOriginal;

	public static void ForceClaimProgressReward(int level, Action onClosePopupReward = null)
	{
	}

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

	private void OnDigging((int x, int y, int indexCellBoardType, ResourceValue resource, ItemInBoard itemInBoard, bool nextLevel) data)
	{
	}

	private void OpenUI_ClaimRewardByLevel(int level, Action onClosePopupReward)
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateUI_StateCompleteLastLevel()
	{
	}

	private void DisableAllMap()
	{
	}

	private void SetCurrentLayerMap(int currentLevel)
	{
	}

	private void NextLayerMap(int nextLevel, Action OnComplete)
	{
	}

	private void UpdateUI_Tutorial()
	{
	}
}
