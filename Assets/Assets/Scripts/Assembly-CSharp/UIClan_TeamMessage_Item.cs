using System;
using GoogleClientTranslate;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

public class UIClan_TeamMessage_Item : MonoBehaviour, IETeamMessage
{
	[Serializable]
	public class UIMessage
	{
		public RectTransform rectBox;

		public Text txtName;

		public Text txtContent;

		public RawImage avatar;

		public UIRect_Profile_FrameAvatar rectFrameAvatar;

		public UIRect_Profile_Badge rectBadge;

		public Button btnInfo;

		public Text txtTime;

		public void UpdateUI(bool isActive, LoopListViewItem2 item, MessageTeam data)
		{
		}

		public void Tween()
		{
		}
	}

	public GoogleClientTranslateSingleForTextLegacy translate;

	public UIMessage mine;

	public UIMessage member;

	public void Tween()
	{
	}

	public void SetItemData(MessageTeam data)
	{
	}
}
