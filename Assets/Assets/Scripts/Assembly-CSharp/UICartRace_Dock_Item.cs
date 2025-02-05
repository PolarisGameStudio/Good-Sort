using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UICartRace_Dock_Item : MonoBehaviour
{
	public Image iconSTT;

	public Sprite[] sprSTTs;

	public Image avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public Text txtName;

	public Text txtNamePremium;

	public TextMeshProUGUI txtScore;

	public RectTransform rectMine;

	public Color colorText;

	public Color colorTextMine;

	public void SetItemData(CartRaceUserInfo data, int rank)
	{
	}
}
