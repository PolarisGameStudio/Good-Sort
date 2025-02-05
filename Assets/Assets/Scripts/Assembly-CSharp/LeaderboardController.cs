using System;
using System.Collections.Generic;

public class LeaderboardController : NMSingleton<LeaderboardController>
{
	private const string key = "leader_real";

	public const int level_unlock_contest = 12;

	private LeaderboardData _data;

	public List<UserInfoLeaderboard> userContest;

	public UserInfoLeaderboard myRank;

	public long timeContestEnd;

	public bool isResetContest;

	public Action<bool> onGetContest;

	public Action onClaimContestReward;

	public GetDataByPage<UserInfoLeaderboard> TopUserWorldData;

	public GetDataByPage<UserInfoLeaderboard> TopUserCountryData;

	public List<LeaderboardMasterUser> masterUsers;

	public Action onGetMasterUser;

	public int teamCode;

	public GetDataByPage<TeamInfoLeaderboard> TopTeamWorldData;

	public GetDataByPage<TeamInfoLeaderboard> TopTeamCountryData;

	public List<LeaderboardMasterTeam> masterTeams;

	public Action onGetMasterTeam;

	public LeaderboardData Data => null;

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

	private void OnSignOut()
	{
	}

	private void OnSignIn(BindDataType type)
	{
	}

	private void Save()
	{
	}

	private void OnSceneChange(SceneState state)
	{
	}

	public bool IsShowTut()
	{
		return false;
	}

	public void ShowTutDone()
	{
	}

	public void UpdateDataFromServer(LeaderboardData leaderboardData)
	{
	}

	public void ClearCache()
	{
	}

	public void GetLeaderboardContest()
	{
	}

	public TimeSpan GetTimeSpanContestEnd()
	{
		return default(TimeSpan);
	}

	public void GetLeaderboardContestFromServer(List<UserInfoLeaderboard> userContest, UserInfoLeaderboard myRank, bool reset, long timeContestEnd)
	{
	}

	public List<ResourceValue> GetResourceValueTopContest(int index)
	{
		return null;
	}

	public void ClaimContestReward()
	{
	}

	public void ClaimContestRewardFromServer(int status)
	{
	}

	private void ClearContestCache()
	{
	}

	public void GetMasterUser()
	{
	}

	public void GetMasterUserFromServer(List<LeaderboardMasterUser> masterUsers)
	{
	}

	public void GetMasterTeam()
	{
	}

	public void GetMasterTeamFromServer(List<LeaderboardMasterTeam> masterTeams)
	{
	}
}
