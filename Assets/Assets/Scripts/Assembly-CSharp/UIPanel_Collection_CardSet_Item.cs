using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_Collection_CardSet_Item : MonoBehaviour
{
	public RectTransform bgShadow;

	public Image icon;

	public Image iconHeadline;

	public TMPFontLocalize txtName;

	public TMPFontLocalize txtNamePremium;

	public RectTransform rectMoreThan;

	public Image iconMoreThan;

	public TMPFontLocalize txtMoreThan;

	public RectTransform rectIsNew;

	public SkeletonGraphic skeBorder;

	[Header("Info Card")]
	public Button btnInfo;

	public UIPopup refPopupInfo;

	public UIPanel_Collection_InfoText refUIPanelInfoText;

	private UIPanel_Collection_CardSet c_Manager;

	private int c_set;

	private int c_index;

	public int GetSetCard => 0;

	public int GetIndexCard => 0;

	public void Refresh_SetItemData()
	{
	}

	public void SetItemData(UIPanel_Collection_CardSet refManager, int set, int index)
	{
	}
}
