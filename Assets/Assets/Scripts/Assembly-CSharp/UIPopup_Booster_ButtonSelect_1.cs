using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Booster_ButtonSelect_1 : MonoBehaviour
{
	public Button btnSelect;

	public Sprite[] sprStateSelects;

	public Image icon;

	public RectTransform rectUnLock;

	public RectTransform rectAmount;

	public TextMeshProUGUI txtAmount;

	public RectTransform rectTimerInfinite;

	public UITimerCountdownTMP timerInfinite;

	public RectTransform rectGetMore;

	public RectTransform rectSelected;

	public RectTransform rectFree;

	public RectTransform rectLock;

	public TextMeshProUGUI txtLevelUnLock;

	public UIPopup refPopupGetMore;

	private BoosterKind c_kind;

	private Sprite c_Icon;

	private Sprite c_IconLock;

	public void SetItemData(BoosterKind kind, Sprite iconSpr, Sprite iconLockSpri)
	{
	}

	private void DisableAll()
	{
	}
}
