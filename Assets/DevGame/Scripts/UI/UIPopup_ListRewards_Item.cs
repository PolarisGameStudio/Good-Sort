using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_ListRewards_Item : MonoBehaviour
{
	public RectTransform rectBoxItem;

	public RectTransform rectDefault;

	public Image iconDefault;

	public TextMeshProUGUI txtValueDefault;

	public RectTransform rectHeadline;

	public Image iconHeadline;

	public TextMeshProUGUI txtValueHeadline;

	private ResourceValue c_data;

	public ResourceValue GetData => null;

	public void SetItemData(ResourceValue data)
	{
	}
}
