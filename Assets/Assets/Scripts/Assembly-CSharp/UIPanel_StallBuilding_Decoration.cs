using System;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_StallBuilding_Decoration : MonoBehaviour
{
	public static Action<int, int> OnSelectDecoration;

	public static Action OnDeSelecteDecoration;

	[Header("UI")]
	public RectTransform viewportDecoration;

	public SkeletonGraphic skeSparky;

	public RectTransform fxUnlockBtnShare;

	public RectTransform fxStarProgressReward;

	public RectTransform rectPreviewTweenIn;

	[Header("Tutorial")]
	public UITutorialSystem tutorialShareHint;

	[Header("Decoration")]
	public UIPanel_StallBulding_HoldOpenDecrationItem panelHoldOpenItem;

	public UIPanel_StallBuilding_Decoration_Item[] items;

	public UIPanel_StallBuilding_Decoration_Slot_Item[] slotItems;

	public UIPopup popupDecorationOptions;

	[Header("Ref & Tween")]
	public Button refBtnTweenIn;

	public RectTransform refRectBtnShare;

	public Button refBtnShare;

	public RectTransform refBGFront;

	public RectTransform refBGBottom;

	public RectTransform refRectTargetLeft;

	public RectTransform refRectTargetRight;

	public RectTransform refRectLockUI_SelectDecoration;

	public RectTransform refRectLockUI_UnlockDecoration;

	private bool c_IsUnlockNewDecortion;

	public void ForceSelectDecoration(int decorIndex, int itemIndex)
	{
	}

	public void ForceDeSelectDecortion()
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

	private void OnDecorationUnlockSlotComplete(int decorIndex, int itemIndex)
	{
	}

	private void OnDecorationUnlockOptionComplete(int decorIndex, int itemIndex)
	{
	}

	private void OnUnlockDecor(int decorIndex, int itemIndex)
	{
	}

	private void OnChangeOptions(int decorIndex, int itemIndex)
	{
	}

	private void Action_OnSelectDecoration(int decorIndex, int itemIndex)
	{
	}

	public Vector3[] GetQuadraticBezierPoints(Vector3 startpoint, Vector3 endPoint, float curveHeigh)
	{
		return null;
	}

	private void Action_OnDeSelecteDecoration()
	{
	}

	private void UpdateUI(bool isDefaultCache = true, bool isForceUpdateDecorationItem = true, bool isForceUpdateSlotItem = true)
	{
	}

	private void UpdateUI_SlotItemsTweenIn()
	{
	}

	private void UpdateUI_SlotItemsTweenOut()
	{
	}

	public void UnlockShare(Action OnComplete)
	{
	}
}
