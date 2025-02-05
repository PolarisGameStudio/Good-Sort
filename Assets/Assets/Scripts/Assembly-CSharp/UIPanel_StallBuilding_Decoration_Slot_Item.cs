using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_StallBuilding_Decoration_Slot_Item : MonoBehaviour
{
	public RectTransform rectTransform;

	public RectTransform rectPreview;

	public RectTransform rectNoti;

	public Button btnSelect;

	public TextMeshProUGUI txtPrice;

	[HideInInspector]
	public bool c_IsLeftPostion;

	[HideInInspector]
	public Vector3 c_AnchorPostionOriginal;

	[Header("Ref")]
	public UIPopup refPopupUnlockSlot;

	public void SetItemData(UIPanel_StallBuilding_Decoration manager, int itemIndex)
	{
	}
}
