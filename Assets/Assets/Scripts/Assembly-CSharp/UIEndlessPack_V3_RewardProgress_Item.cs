using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIEndlessPack_V3_RewardProgress_Item : MonoBehaviour
{
	public UIPopup_ListRewards_V2_Item reward;

	public RectTransform rectNumberPoint;

	public TextMeshProUGUI txtNumberPoint;

	public Button btnClaim;

	public RectTransform rectComplete;

	private int c_ItemIndex;

	private int c_NumberPointTarget;

	private ResourceValue c_DataReward;

	public void Refresh()
	{
	}

	public void SetItemData(int itemIndex, int numberPointTarget, ResourceValue dataReward)
	{
	}
}
