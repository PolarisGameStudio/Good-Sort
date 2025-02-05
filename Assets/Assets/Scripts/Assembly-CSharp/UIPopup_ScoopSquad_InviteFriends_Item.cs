using UnityEngine;
using UnityEngine.UI;

public class UIPopup_ScoopSquad_InviteFriends_Item : MonoBehaviour
{
	public Text txtName;

	public Text txtNamePremium;

	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public Text txtTeam;

	public RectTransform rectInviations;

	public Button btnInviationsAccept;

	public Button btnInviationsDecline;

	public RectTransform rectFriends;

	public Button btnFriendSend;

	public RectTransform rectSuggest;

	public Button btnSuggestSend;

	public Button btnSuggestDismiss;

	public void SetItemData(int indexSlot, int typeData, UIPopup_ScoopSquad_InviteFriends.DataUserInfo dataInfo)
	{
	}
}
