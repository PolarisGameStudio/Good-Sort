using System;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Collection_CardReceive_Item : MonoBehaviour
{
	public RectTransform viewport;

	public UIPopup_UnlockCollection_CardSet_Item cardItem;

	public Text txtName;

	public Text txtNamePremium;

	public RawImage avatar;

	public UIRect_Profile_FrameAvatar rectFrameAvatar;

	public UIRect_Profile_Badge rectBadge;

	public Text txtTeam;

	private CardData c_DataCard;

	public CardData DataCard => null;

	public void Hide()
	{
	}

	public void FadeIn()
	{
	}

	public void FadeOut(float delay, Action onComplete)
	{
	}

	public void SetItemData(UserInfoSendCard dataUser, CardData dataCard)
	{
	}
}
