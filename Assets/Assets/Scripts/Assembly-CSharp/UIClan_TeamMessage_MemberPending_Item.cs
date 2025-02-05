using UnityEngine;
using UnityEngine.UI;

public class UIClan_TeamMessage_MemberPending_Item : MonoBehaviour, IETeamMessage
{
	public RectTransform rectBox;

	public Text txtName;

	public UIContentSizeFitter contentName;

	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public Button btnInfo;

	public Button btnNo;

	public Button btnYes;

	public void Tween()
	{
	}

	public void SetItemData(UIClan_TeamMessage refManager, MessageTeam data)
	{
	}
}
