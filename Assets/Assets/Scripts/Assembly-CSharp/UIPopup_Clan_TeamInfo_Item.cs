using Falcon.PuzzleCore.Team;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Clan_TeamInfo_Item : MonoBehaviour
{
	public RectTransform rectLeader;

	public Image bg;

	public Sprite[] sprBgs;

	public TextMeshProUGUI txtSTT;

	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public Text txtName;

	public Text txtNamePremium;

	public TextMeshProUGUI txtHelps;

	public TextMeshProUGUI txtLevel;

	public Color[] colorNames;

	[Header("Info")]
	public Button btnInfo;

	public UIPopup_Clan_TeamInfo_AddonMembers refAddonMember;

	public void SetItemData(int itemIndex, TeamInfo dataTeam, TeamMemberInfo data)
	{
	}
}
