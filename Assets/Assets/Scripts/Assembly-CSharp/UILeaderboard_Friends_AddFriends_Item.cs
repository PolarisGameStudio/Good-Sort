using UnityEngine;
using UnityEngine.UI;

public class UILeaderboard_Friends_AddFriends_Item : MonoBehaviour
{
	public Text txtName;

	public Text txtNamePremium;

	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public Text txtTeam;

	public Button btnInfo;

	public Button btnDismiss;

	public Button btnAdd;

	public void SetItemData(int itemIndex, UserSimpleInfoWithTeam data)
	{
	}
}
