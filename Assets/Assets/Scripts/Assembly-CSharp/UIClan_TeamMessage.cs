using System.Collections.Generic;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

public class UIClan_TeamMessage : MonoBehaviour
{
	[Header("Message")]
	public InputField inputMessage;

	public Button btnMessage;

	public Button btnRequestLive;

	public Button btnRequestLiveWaiting;

	public UITimerCountdownTMP timerLiveWaiting;

	public LoopListView2 loopScrollView;

	public RectTransform rectLoading;

	[Header("Infor")]
	public Image avatar;

	public Text txtName;

	public Button btnInfo;

	private bool initLoopScrollView;

	private bool isCanNextPage;

	private List<MessageTeam> c_MessageTeam;

	private void Start()
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

	private void OnResponJoinRequest(MessageTeam team)
	{
	}

	private void OnGetTeamChat()
	{
	}

	private void OnSendChatSuccess()
	{
	}

	private void OnSpamChat()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateUI_StateRequestLive()
	{
	}

	private void UpdateUI_ScrollMessage()
	{
	}

	private void UpdateUI_ScrollMoveToFirst()
	{
	}

	private LoopListViewItem2 InitLoopListView(LoopListView2 view, int itemIndex)
	{
		return null;
	}
}
