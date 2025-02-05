using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Profile_SelectBadge_Item : MonoBehaviour
{
	public UIRect_Profile_Badge rectBadge;

	public UIPanel_Collection_BadgeTheme rectFrameLock;

	public UIPanel_Collection_BadgeTheme rectFrameSelected;

	public RectTransform rectLock;

	public RectTransform rectSelected;

	public Button btnSelect;

	public bool IsUnlock;

	public void SetItemData(int index, UIPopup refPopupConfirm)
	{
	}
}
