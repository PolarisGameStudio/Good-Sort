using System;
using UnityEngine;
using UnityEngine.UI;

public class UIClan_TeamMessage_ScoopSquad_Item : MonoBehaviour, IETeamMessage
{
	[Serializable]
	public class UIMessage
	{
		public RectTransform rectBox;

		public Text txtName;

		public RawImage avatar;

		public UIRect_Profile_FrameAvatar rectFrameAvatar;

		public UIRect_Profile_Badge rectBadge;

		public Button btnInfo;

		public void UpdateUI(bool isActive, MessageTeam data)
		{
		}

		public void Tween()
		{
		}
	}

	public UIMessage mine;

	public UIMessage member;

	public Button btnJoin;

	public Button btnJoinLock;

	private MessageTeam c_data;

	public void Tween()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnJoinStarCollab(int status)
	{
	}

	public void SetItemData(MessageTeam data)
	{
	}
}
