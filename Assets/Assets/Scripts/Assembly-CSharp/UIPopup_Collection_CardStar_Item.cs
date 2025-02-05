using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Collection_CardStar_Item : MonoBehaviour
{
	public Button btnChest;

	public SkeletonGraphic[] iconChests;

	public RectTransform rectBtnBuy;

	public Button btnBuy;

	public TextMeshProUGUI txtBuy;

	public RectTransform rectBtnBuyDisable;

	public Button btnBuyDisable;

	public TextMeshProUGUI txtBuyDisable;

	[Header("Ref")]
	public UIPanel_UnlockReward_Info refInfo;

	public void SetItemData(int itemIndex)
	{
	}
}
