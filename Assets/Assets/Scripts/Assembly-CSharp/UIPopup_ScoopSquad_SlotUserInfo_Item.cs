using UnityEngine;
using UnityEngine.UI;

public class UIPopup_ScoopSquad_SlotUserInfo_Item : MonoBehaviour
{
	public RectTransform rectTransform;

	[Header("Progress Reward")]
	public Slider progressReward;

	public UIPopup_ListRewards_V2_Item reward_1;

	public Button btnReward_2;

	public Button btnReward_3;

	[Header("Nav")]
	public RectTransform rectActive;

	public Button btnInfo;

	public RectTransform rectBtnOpen;

	public Button btnOpen;

	public RectTransform rectBlank;

	public Button btnInviteFriends;

	public UIPopup refPopupInviteFriends;

	public RectTransform rectComplete;

	public RectTransform rectScoreUpdate;

	public RectTransform rectScoreUpdateWithCanClaimProgress;

	[Header("Info")]
	public Text txtName;

	public Text txtNamePremium;

	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	private UIPopup_ScoopSquad c_Manager;

	private int c_IndexSlot;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnRefrest_SetItemData(int obj1, int obj2)
	{
	}

	public void SetItemData(UIPopup_ScoopSquad refManager, int indexSlot)
	{
	}
}
