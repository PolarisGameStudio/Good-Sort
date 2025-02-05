using System;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_StallBuilding_DecorationUnlockSlot : MonoBehaviour
{
	public static Action<int, int> OnDecorationUnlockSlotComplete;

	public RectTransform viewport;

	public TextMeshProUGUI txtName;

	public RectTransform rectPreview;

	public RectTransform rectNoti;

	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	[Header("Get More Envelope")]
	public Button btnGetMore;

	public TextMeshProUGUI txtEnvelope;

	[Header("Tween Buy Decoration")]
	public RectTransform[] iconFlys;

	public UIParticle[] fxIconFlys;

	public RectTransform rectOutsideBtnBuy;

	public RectTransform rectInsideBtnBuy;

	public RectTransform[] pointTargetFlys;

	public RectTransform rectLockUI;

	private UIPanel_StallBuilding_Decoration c_Manager;

	private int c_ItemIndex;

	private Vector3[] posPointTargetFlys;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnBuyEnvelope(int obj)
	{
	}

	private void OnUnlockDecor(int decorIndex, int itemIndex)
	{
	}

	private void UpdateUI_Refresh()
	{
	}

	public void UpdateUI(UIPanel_StallBuilding_Decoration manager, int itemIndex)
	{
	}

	private void UpdateUI_Envelope()
	{
	}
}
