using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_Collection_CardSet_Empty_Item : MonoBehaviour
{
	public RectTransform[] rectBGCards;

	public RectTransform[] iconStars;

	public TextMeshProUGUI txtName;

	public Color[] colorTxtNames;

	[Header("Info Card")]
	public Button btnInfo;

	public UIPanel_Collection_InfoText refUIPanelInfoText;

	public void SetItemData(int set, int index)
	{
	}
}
