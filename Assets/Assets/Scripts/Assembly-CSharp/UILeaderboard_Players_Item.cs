using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UILeaderboard_Players_Item : MonoBehaviour
{
	public RectTransform rectMine;

	public Image iconSTT;

	public Sprite[] sprIconSTTs;

	public TextMeshProUGUI txtSTT;

	public Text txtName;

	public Text txtNamePremium;

	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public Color[] colorNames;

	public Text txtTeam;

	public TextMeshProUGUI txtScore;

	public Button btnInfo;

	private int c_itemIndex;

	private UserInfoLeaderboard c_data;

	public int GetItemIndex => 0;

	public UserInfoLeaderboard GetData => null;

	public bool IsYourSelf => false;

	public void SetItemData(int itemIndex, UserInfoLeaderboard data)
	{
	}
}
