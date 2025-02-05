using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_ListRewards_V2_Item : MonoBehaviour
{
	public RectTransform rectBoxItem;

	public Image icon;

	public TextMeshProUGUI txtValue;

	private ResourceValue c_data;

	public ResourceValue GetData => null;

	public void SetItemData(ResourceValue data)
	{
	}
}
