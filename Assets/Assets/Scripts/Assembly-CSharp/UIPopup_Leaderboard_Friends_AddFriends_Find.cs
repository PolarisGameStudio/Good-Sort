using System.Collections.Generic;
using SuperScrollView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Leaderboard_Friends_AddFriends_Find : MonoBehaviour
{
	public InputField inputFieldName;

	public Button btnRemoveField;

	public Button btnSearch;

	public Button btnInviteFriends;

	public TextMeshProUGUI txtID;

	public LoopListView2 loopListView;

	public UIPanel_TimeOutLoading rectLoading;

	public RectTransform rectEmpty;

	private bool initGridView;

	private List<UserInfoSearch> c_data;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnGetFriendSuggest()
	{
	}

	private void UpdateUI_Scroll(List<UserInfoSearch> data)
	{
	}

	private LoopListViewItem2 InitListView(LoopListView2 view, int itemIndex)
	{
		return null;
	}
}
