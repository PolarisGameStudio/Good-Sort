using System;
using System.Collections.Generic;

public class TeamTreasureDataController : NMSingleton<TeamTreasureDataController>
{
	public enum TeamTreasureState
	{
		Close = 0,
		Tut = 1,
		Start = 2,
		Activating = 3,
		Ended = 4
	}

	private int _shovelReceiveFromLevel;

	private int _state;

	private long _timeEnd;

	public Action onCheckState;

	private List<UserInfoTeamTreasure> _userInfos;

	private int _totalScore;

	private List<int> _targetScores;

	private List<int> _rewardStates;

	private TeamInfoSimple _teamInfo;

	private bool _canClaimRewardByRank;

	private const string key_pre_score = "team_treasure_pre_score";

	public Action onGetTeamTreasureInfo;

	public Action<int> onClaimReward;

	public Action<List<ResourceValue>> OnConfirmEnd;

	public int ShovelReceiveFromLevel => 0;

	public TeamTreasureState State => default(TeamTreasureState);

	public List<UserInfoTeamTreasure> UserInfos => null;

	public UserInfoTeamTreasure MyUserInfo => null;

	public int MyRank => 0;

	public int TotalScore => 0;

	public List<int> TargetScores => null;

	public TeamInfoSimple TeamInfo => null;

	protected override void Init()
	{
	}

	public void ComfirmShovelFromLevel()
	{
	}

	private void OnLevelDataComplete()
	{
	}

	public TimeSpan GetTimeEnd()
	{
		return default(TimeSpan);
	}

	public void CheckTeamState()
	{
	}

	public void CheckTeamStateFromServer(SCCheckTeamTreasure sc)
	{
	}

	public void GetTeamTreasureInfo()
	{
	}

	private void SortUseInfo()
	{
	}

	public ResourceValue GetResourceCanClaimByRank()
	{
		return null;
	}

	public void ClaimResourceByRank()
	{
	}

	public int GetPreScore()
	{
		return 0;
	}

	public void UpdatePreScore()
	{
	}

	private void ResetPreScore()
	{
	}

	public void GetTeamTreasureFromServer(SCGetTeamTreasureInfo sc)
	{
	}

	public ResourceValue GetResourceValueByRank(int rankIndex)
	{
		return null;
	}

	public List<ResourceValue> GetResourceValuesTeamProgress(int index)
	{
		return null;
	}

	public RewardState GetRewardState(int index)
	{
		return default(RewardState);
	}

	public (bool, int) DetailStateClaimReward()
	{
		return default((bool, int));
	}

	public bool IsEndedWithoutReward()
	{
		return false;
	}

	public bool AnyRewardCanClaim()
	{
		return false;
	}

	public bool AllRewardClaimed()
	{
		return false;
	}

	public bool CanClaimReward(int index)
	{
		return false;
	}

	public void ClaimReward(int index)
	{
	}

	public void ClaimRewardTeamTreasure(SCClaimRewardTeamTreasure sCClaimRewardTeamTreasure)
	{
	}

	public void ConfirmEnd()
	{
	}

	public void ConfirmEndFromServer(SCConfirmEndTeamTreasure sc)
	{
	}
}
