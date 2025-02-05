using System.Collections.Generic;
using Falcon.PuzzleCore.Team;
using SuperScrollView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Clan_TeamInfo : MonoBehaviour
{
	public RectTransform viewport;

	public Image avatar;

	public Text txtName;

	public Text txtDescription;

	public TextMeshProUGUI txtMember;

	public TextMeshProUGUI txtScore;

	public RectTransform[] rectStateActivities;

	public TextMeshProUGUI txtWeeklyHelps;

	public TextMeshProUGUI txtRequireLevel;

	public TextMeshProUGUI txtTeamType;

	public TextMeshProUGUI txtID;

	public RectTransform rectBtnLeave;

	public Button btnLeave;

	public RectTransform rectBtnJoin;

	public Button btnJoin;

	public RectTransform rectPending;

	public RectTransform rectBtnEdit;

	public Button btnEdit;

	public UIPopup popupEdit;

	public LoopGridView gridScrollView;

	public CanvasGroup canvasGroupScrollViewport;

	public RectTransform rectLoading;

	private bool initGridView;

	private TeamInfo c_data;

	private List<TeamMemberInfo> c_Member_Infos;

	private bool c_IsCanTweenIn;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnRequestJoinTeam(int status)
	{
	}

	private void OnEditTeamInfo(int status)
	{
	}

	private void OnUpdateUI()
	{
	}

	public void UpdateUI(int codeTeam)
	{
	}

	private void UpdateUI(TeamInfo data)
	{
	}

	private LoopGridViewItem InitGridView(LoopGridView view, int itemIndex, int arg3, int arg4)
	{
		return null;
	}

	private void ForceClosePopup()
	{
	}
}
