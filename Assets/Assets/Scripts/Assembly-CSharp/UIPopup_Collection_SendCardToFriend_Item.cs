using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Collection_SendCardToFriend_Item : MonoBehaviour
{
	public Text txtName;

	public Text txtNamePremium;

	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public Text txtTeam;

	public Button btnSend;

	public UIPopup refPopupSendConform;

	private UserSimpleInfoWithTeam c_data;

	public void SetItemData(int itemIndex, UserSimpleInfoWithTeam data)
	{
	}

	public void SetItemData_SendCard(int setCard, int indexCard)
	{
	}
}
