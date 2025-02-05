using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Booster_ButtonSelect : MonoBehaviour
{
	public Button btnSelect;

	public Sprite[] sprStateSelects;

	public Image icon;

	public RectTransform rectAmount;

	public TextMeshProUGUI txtAmount;

	public RectTransform rectTimerInfinite;

	public UITimerCountdownTMP timerInfinite;

	public RectTransform rectGetMore;

	public RectTransform rectLock;

	public RectTransform rectSelected;

	public RectTransform rectFree;

	public UIPopup refPopupGetMore;

	private BoosterKind c_kind;

	public void SetItemData(BoosterKind kind)
	{
	}

	private void DisableAll()
	{
	}
}
