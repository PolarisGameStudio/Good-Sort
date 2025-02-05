using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIClan_TeamMessage_RequestLive_Item : MonoBehaviour, IETeamMessage
{
	[Serializable]
	public class UIMessage
	{
		public RectTransform rectBox;

		public Text txtName;

		public UIContentSizeFitter contentName;

		public Image progress;

		public TextMeshProUGUI txtProgress;

		public RawImage avatar;

		public UIRect_Profile_FrameAvatar rectFrameAvatar;

		public UIRect_Profile_Badge rectBadge;

		public Button btnInfo;

		public Text txtTime;

		public void UpdateUI(bool isActive, MessageTeam data)
		{
		}

		public void Tween()
		{
		}
	}

	public UIMessage mine;

	public UIMessage member;

	public Button btnHelp;

	public Image imgHelp;

	public Sprite[] sprImgHelps;

	private MessageTeam c_data;

	public void Tween()
	{
	}

	public void SetItemData(UIClan_TeamMessage refManager, MessageTeam data)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDonateHeart(int status, MessageTeam data)
	{
	}
}
