using System;
using Coffee.UIExtensions;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_StallBuilding_DecorationOptions : MonoBehaviour
{
	public static Action<int, int> OnDecorationUnlockOptionComplete;

	public static int s_IndexOptionSelected;

	public static Action<int, int> OnChangeOptions;

	[Header("Tween")]
	public RectTransform rectLockUI;

	public RectTransform[] iconFlys;

	public UIParticle[] fxIconFlys;

	public UIPopup_StallBuilding_DecorationOptions_Item[] items;

	public DOTweenAnimation tweenRectBtnApplyNewUnlock;

	public RectTransform rectFxNewUnlock;

	[Header("Apply Button")]
	public Button btnApply;

	public Button btnApplyDisable;

	public Button[] btnCloseUIs;

	[Header("Get More Envelope")]
	public RectTransform iconEnvelopeGetMore;

	public Button btnGetMore;

	public TextMeshProUGUI txtEnvelope;

	private UIPanel_StallBuilding_Decoration c_Manager;

	private int c_DecorIndex;

	public static void ForceSelectOption(int decorIndex, int itemIndex)
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

	private void Action_OnChangeOptions(int decorIndex, int itemIndex)
	{
	}

	private void OnUnlockDecor(int decorIndex, int itemIndex)
	{
	}

	private void OnBuyEnvelope(int obj)
	{
	}

	public void UpdateUI(UIPanel_StallBuilding_Decoration manager, int decorIndex, int itemIndex)
	{
	}

	private void UpdateUI_Envelope()
	{
	}

	private Vector3[] GetQuadraticBezierPoints(Vector3 startpoint, Vector3 endPoint, float curveHeigh)
	{
		return null;
	}
}
