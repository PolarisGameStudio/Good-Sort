using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_ScoopSquad : MonoBehaviour
{
	public static RectTransform s_RectUIPopupScoopSquad;

	public static RectTransform s_RectUICurrentPoint;

	public static Action<int> OnSwitchCream;

	private static int c_SlotIndexSelected;

	private static float lastSwitchTime;

	private const float SWITCH_COOLDOWN = 0.75f;

	public Button btnExit;

	public UIPanel_ScoopSquad_SlotReward panelDetailSlotReward;

	public UIPanel_ScoopSquad_Wheel panelDetailSlotWheel;

	public UIPanel_ScoopSquad_HomeUserScoreForSlotTarget panelDetailHomeUserScore;

	public UIPanel_TimeOutLoading rectLoading;

	public UITutorialSystem uiTutorial;

	[Header("UI Data Visual")]
	public UIPopup_ScoopSquad_SlotUserInfo_Item[] slotUserInfoItems;

	public UIPopup_ScoopSquad_SlotTarget_Item[] slotTargetItems;

	public Vector3[] anchorPosOriginalTargetItems;

	public float[] scaleOriginalTargetItems;

	public Vector3 anchorPosDetailTargetItem;

	public float scaleDetailTargetItem;

	public Vector3 anchorPosFinalDetailTargetItem;

	public float scaleFinalDetailTargetItem;

	[Header("Home")]
	public RectTransform rectBG;

	public Vector3 anchorPosDetailTargetBG;

	public float scaleDetailTargetBG;

	public Vector3 anchorPosFinalDetailTargetBG;

	public float scaleDetailFinalTargetBG;

	public RectTransform rectHome;

	public RectTransform rectHomeSlotTargetDetail;

	public TextMeshProUGUI txtCurrentPoint;

	[Header("Slot Layout")]
	public RectTransform rectSlotLayoutLeft;

	public RectTransform rectSlotLayoutRight;

	public RectTransform rectSlotLayoutLeftAnchor;

	public RectTransform rectSlotLayoutRightAnchor;

	public RectTransform rectSlotTargets;

	public RectTransform rectBigReward;

	public DOTweenAnimation rectDOTweenCurrentPoint;

	public DOTweenAnimation rectDOTweenWheelComplete;

	[Header("Machine")]
	public RectTransform rectMachine;

	private bool c_IsShowTutorial;

	public static bool IsOpenSlotTargetDetail => false;

	public static void PrevPreviewCream()
	{
	}

	public static void NextPreviewCream()
	{
	}

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

	private void OnListingSwitchCream(int slotIndex)
	{
	}

	private void OnClaimRewardProgress(int indexSlot, int indexReward)
	{
	}

	private void OnResponRequest()
	{
	}

	private void OnGetStarCollabInfo()
	{
	}

	private void OpenUI_DetailSlotTarget()
	{
	}

	private void OpenUI_DetailSlotTarget_Final()
	{
	}

	private void CloseUI_DetailSlotTarget()
	{
	}

	private void TweenRectCurrentPoint(bool isRestart = false)
	{
	}

	public void State_OpenDetailSlotTargetItem(int slotIndex)
	{
	}

	public void State_CloseDetailSlotTargetItem()
	{
	}

	private void UpdateTextCurrentPoint()
	{
	}

	private void UpdateUI_Tutorial()
	{
	}
}
