using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Collection_SendCardToFriend_Confirm : MonoBehaviour
{
	public Button btnContinue;

	public UIPanel_TimeOutLoading rectLoading;

	[Header("Card")]
	public Image icon;

	public Image iconHeadline;

	public TMPFontLocalize txtNameCard;

	public TMPFontLocalize txtNameCardPremium;

	public RectTransform rectMoreThan;

	public Image iconMoreThan;

	public TMPFontLocalize txtMoreThan;

	public SkeletonGraphic skeBorder;

	[Header("User")]
	public Text txtName;

	public Text txtNamePremium;

	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSendCardToFriend()
	{
	}

	public void UpdateUI(int setCard, int indexCard, UserSimpleInfoWithTeam data)
	{
	}
}
