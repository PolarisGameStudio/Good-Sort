using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_Collection_CardSet : MonoBehaviour
{
	public Image bg;

	public Sprite[] sprBgBySets;

	public Image bgExit;

	public Sprite[] sprBgExitBySets;

	public TMPFontLocalize txtTitle;

	public Slider progress;

	public TextMeshProUGUI txtProgress;

	public Button btnInfoCardProgress;

	public UIPanel_Collection_InfoText uiPanelInfoText;

	public UIPopup_ListRewards_V2_Item reward;

	public UIPanel_Collection_CardSet_Empty_Item[] emptyItems;

	public UIPanel_Collection_CardSet_Item[] items;

	public RectTransform rectLayout;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void UpdateUI()
	{
	}
}
