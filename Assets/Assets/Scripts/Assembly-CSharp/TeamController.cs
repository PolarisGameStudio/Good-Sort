using System;
using System.Collections.Generic;
using Falcon.PuzzleCore.Team;

public class TeamController : NMSingleton<TeamController>
{
	private const string key = "clan";

	public const int MAX_MEMBER_PER_TEAM = 50;

	public const int level_unlock = 11;

	public const int MAX_DONATE_PER_REQUEST = 5;

	private TeamInfo _teamInfo;

	private TeamData _data;

	public Action onCheckTeamState;

	public Action<int> onCreateTeam;

	public Action<List<TeamInfoSimple>> onGetTeamInfoRandom;

	public Action<List<TeamInfoSimple>> onGetSearchTeamByName;

	public Action<int> onRequestJoinTeam;

	public Action<int> onEditTeamInfo;

	public Action<MessageTeam> onResponJoinRequest;

	public Action onRemoveMember;

	public int totalPage;

	private List<MessageTeam> _totalMessage;

	public Dictionary<int, List<MessageTeam>> messageByPage;

	public Action onGetTeamChat;

	public int curPage;

	public Action onSpamChat;

	public Action onSendChatSuccess;

	public Action<int, MessageTeam> onDonateHeart;

	private Action<TeamInfo> onGetTeamInfo;

	public Action<int> onJoinStarCollab;

	private List<int> _messageIDJoinStarCollabExprice;

	public TeamInfo TeamInfo => null;

	public TeamData TeamData => null;

	public static int gold_to_create_team => 0;

	public List<MessageTeam> totalMessage => null;

	public bool IsUnlock()
	{
		return false;
	}

	protected override void Init()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void Save()
	{
	}

	private void OnSceneChange(SceneState state)
	{
	}

	private void ClearCache()
	{
	}

	public bool IsShowTut()
	{
		return false;
	}

	public void ShowTutDone()
	{
	}

	public void UpdateDataFromServer(TeamData teamData)
	{
	}

	public void CheckTeamState()
	{
	}

	public void OnCheckTeamStateFromServer(TeamInfo teamInfo)
	{
	}

	public bool CanCreateTeam()
	{
		return false;
	}

	public void CreateTeam(int avatarId, string name, string des, bool open, int levelRequire)
	{
	}

	public void OnCreateTeamFromServer(int status)
	{
	}

	public void GetRandomTeam()
	{
	}

	public void OnGetRandomTeamFromServer(List<TeamInfoSimple> team_infos)
	{
	}

	public void SearchTeamByName(string teamName)
	{
	}

	public void OnGetSearchTeamByNameFromServer(List<TeamInfoSimple> team_infos)
	{
	}

	public void LeaveTeam()
	{
	}

	public void RequestJoinTeam(int teamCode)
	{
	}

	public void RequestJoinTeamFromServer(int status)
	{
	}

	public void EditTeamInfo(int avatarId, string name, string des, bool open, int levelRequire)
	{
	}

	public void EditTeamFromServer(int status, TeamInfo team)
	{
	}

	public void ResponJoinRequest(long messageId, bool accept)
	{
	}

	public void ResponJoinRequestFromServer(int status, MessageTeam messageTeam, TeamInfo teamInfo)
	{
	}

	public void RemoveMember(int code)
	{
	}

	public void RemoveMemberFromServer(int status, TeamInfo teamInfo)
	{
	}

	public bool CanRequestHeart()
	{
		return false;
	}

	public TimeSpan GetTimeSpanRequestHeart()
	{
		return default(TimeSpan);
	}

	public void GetTeamChat(int page)
	{
	}

	public bool CanSendMessageMerrychristmas()
	{
		return false;
	}

	public TimeSpan GetTimeRemainingSendMerryChristmas()
	{
		return default(TimeSpan);
	}

	public bool ContainMessageMerrychristmas()
	{
		return false;
	}

	public int GetIndexMessageMerrychristmas()
	{
		return 0;
	}

	private MessageTeam GetMerryChristmasMessage()
	{
		return null;
	}

	public bool CanShowConfestMerryChristmas()
	{
		return false;
	}

	public void ConfirmViewMerryChristmas()
	{
	}

	public void SendMerryChristmasMessage()
	{
	}

	public void GetTeamChatFromServer(int page, int totalPage, List<MessageTeam> messages)
	{
	}

	private void ValidateMessage(List<MessageTeam> messages)
	{
	}

	public int GetNumRequestHeart()
	{
		return 0;
	}

	public void SendChat(int type, string content)
	{
	}

	public void OnSpamChatFromServer()
	{
	}

	public void SendChatFromServer(MessageTeam message)
	{
	}

	public bool CanDonateHearth(long messageId)
	{
		return false;
	}

	public void DonateHeart(long messageId)
	{
	}

	public void DonateHearFromServer(int status, MessageTeam messageTeam)
	{
	}

	private void UpdateMessageTeam(MessageTeam messageTeam)
	{
	}

	public void GetTeamInfo(int code, Action<TeamInfo> callBack)
	{
	}

	public void GetTeamInfoFromServer(TeamInfo teamInfo)
	{
	}


	public bool CanJoinStarCollab(MessageTeam messageTeam)
	{
		return false;
	}

	public void RequestJoinStarCollab(long messageId)
	{
	}

	public void JoinStarCollabFromServer(SCJoinTeamStarCollabQueue sc)
	{
	}
}
