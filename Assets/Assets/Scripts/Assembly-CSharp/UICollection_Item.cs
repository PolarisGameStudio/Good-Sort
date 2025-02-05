using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UICollection_Item : MonoBehaviour
{
	public Image iconFeatture;

	public TMPFontLocalize txtName;

	public Slider progress;

	public TextMeshProUGUI txtProgress;

	public UIPopup_ListRewards_V2_Item reward;

	public RectTransform rectNew;

	public TextMeshProUGUI txtNew;

	public RectTransform rectComplete;

	public Button btnInfo;

	public RectTransform rectBtnClaim;

	public Button btnClaim;

	[Header("Ref")]
	public UIPopup refPopupCardSet;

	public void SetItemData(int itemIndex, CardSet data)
	{
	}
}
