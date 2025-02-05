using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_StarRush_Item : MonoBehaviour
{
	public Image iconSTT;

	public Sprite[] sprSTTs;

	public Image avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public Text txtName;

	public Text txtNamePremium;

	public TextMeshProUGUI txtStar;

	public RectTransform rectMine;

	public Button btnReward;

	public RectTransform rectInfoReward;

	public UIPopup_ListRewards_Item[] itemRewards;

	public Color colorText;

	public Color colorTextMine;

	private int c_star;

	public void SetItemData(UserStarRushInfo data)
	{
	}

	public void SetItemData_Change(UserStarRushInfo data)
	{
	}
}
