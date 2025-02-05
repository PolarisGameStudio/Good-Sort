using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_StallBuilding_ListReward_Item : MonoBehaviour
{
	public RectTransform rectProgressSTT;

	public Image bgSTT;

	public Sprite[] sprSTTs;

	public TextMeshProUGUI txtSTT;

	public UIPopup_ListRewards_V2_Item itemDefault;

	public Button btnBoxReward;

	public SkeletonGraphic[] skeChests;

	public RectTransform[] rectCurrents;

	[Header("Lock")]
	public RectTransform iconLock;

	public SkeletonGraphic skeLock;

	public void SetItemData(UIPopup_StallBuilding_ListReward manager, int itemIndex)
	{
	}
}
