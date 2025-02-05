using System;
using System.Collections.Generic;

public class TeamBattlesDataController : NMSingleton<TeamBattlesDataController>
{
	private class TeamBattleSocre
	{
		public int seasion;

		public int score;
	}

	public enum BattleState
	{
		Close = 0,
		Prepare = 1,
		Open = 2,
		Activating = 3,
		Ended = 4
	}

	public enum TeamState
	{
		NoTeam = 0,
		TeamCanNotJoin = 1,
		TeamCanJoin = 2
	}

	private const string key_team_battle_score = "team_battle_score";

	private const int max_score_when_offline = 30;

	private const string key_team_battle = "team_battle";

	private TeamBattle _teamBattle;

	private int _seasonId;

	private int _state;

	private long _timeEnd;

	private int _myRankIndividual;

	private int _myRankTeam;

	private int _teamState;

	private List<TeamBattleInfo> _teamInfos;

	private TeamBattleInfo _myTeam;

	private int _userScore;

	public Action onCheckTeamBattleState;

	public Action onGetTeamBattleInfo;

	private TeamBattleInfoDetail teamBattleInfoDetail;

	private UserInfoTeamBattle _myUserInforTeamBattle;

	private bool _isParticipate;

	public Action<ResourceValue, ResourceValue> onConfirmEnd;

	public int scoreAdded;

	public TeamBattle TeamBattle => null;

	public BattleState State => default(BattleState);

	public int MyRankIndividual => 0;

	public int MyRankTeam => 0;

	public int MyPreRankTeam => 0;

	public TeamState TeamJoinState => default(TeamState);

	public List<TeamBattleInfo> TeamInfos => null;

	public TeamBattleInfo MyTeam => null;

	public List<UserInfoTeamBattle> UserInfoTeamBattles => null;

	public UserInfoTeamBattle MyUserInforTeamBattle => null;

	public bool IsParticipate => false;

	protected override void Init()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void Save()
	{
	}

	private void LevelComplete()
	{
	}

	public bool IsUnlock()
	{
		return false;
	}

	public bool IsShowTut()
	{
		return false;
	}

	public void ShowTut()
	{
	}

	public void UpdateDataFromServer(TeamBattle teamBattle)
	{
	}

	public TimeSpan GetTimeSpan()
	{
		return default(TimeSpan);
	}

	public void CheckState()
	{
	}

	public void CheckStateFromServer(SCCheckTeamBattle sCCheck)
	{
	}

	public bool CanClaim()
	{
		return false;
	}

	public void JoinTeamBattle()
	{
	}

	public void GetTeamBattleInfoFromServer(SCTeamBattleInfo teamBattleInfo)
	{
	}

	public void GetBattleTeamInfo()
	{
	}

	public void GetMyTeamInfo()
	{
	}

	public void GetMyTeamInfoFromServer(TeamBattleInfoDetail teamBattleInfo)
	{
	}

	public void ComfirmEnd()
	{
	}

	public void ConfirmEndFromServer(SCConfirmEndTeamBattle sCConfirmEndTeam)
	{
	}

	public ResourceValue GetResourceValueTeam(int rank)
	{
		return null;
	}

	public ResourceValue GetResourceValueIndividual(int rank)
	{
		return null;
	}

	public void ConfirmUpdate()
	{
	}
}
