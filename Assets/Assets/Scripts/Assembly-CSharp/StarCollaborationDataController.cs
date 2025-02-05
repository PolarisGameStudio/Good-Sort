using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

public class StarCollaborationDataController : NMSingleton<StarCollaborationDataController>
{
	[Serializable]
	public class ScoopDataToLog
	{
		public long timeEnd;

		public long lastLog;

		public int totalMilk;

		public int totalSpin;

		public int milestones;

		public int GetTotalMilestone()
		{
			return 0;
		}
	}

	private ScoopDataToLog _dataLog;

	private const string key_log = "scoop_log";

	public const int frame_id = -2;

	public const int level_unlock = 41;

	private const int level_can_show_popup = 30;

	private int _targetScoreInProgress;

	private int _numRewardInLuckyWheel;

	private const int max_slot = 4;

	private int _milkReceiveFromLevel;

	public bool _isShowedPopup;

	public Action onCheckState;

	private int _state;

	private long _timeEnd;

	private int _numEmptySlot;

	private int _milk;

	private List<UserInfoStarCollab> _userInfoCollabs;

	private int _grandReward;

	private long _timeInviteTeam;

	private const int num_partner = 4;

	public Action onGetStarCollabInfo;

	private List<UserSimpleInfo> _pendings;

	private List<UserSimpleInfo> _friends;

	private List<UserSimpleInfo> _suggestions;

	public Action onGetFriendSuggest;

	public Action onInvite;

	public Action onResponRequest;

	public Action onDismiss;

	private List<int> targetPoints;

	private List<float> ratios;

	public Action<int, int> onSpin;

	private int _spinIndex;

	private List<int> _spinTypes;

	private const string key_spin_type = "scoop_spin_type";

	public Action onClaimGrandReward;

	public Action<int, int> onClaimRewardProgress;

	public Action<int> onInviteTeam;

	public int NumRewardInLuckyWheel => 0;

	public ObscuredInt NumMilkToSpin => default(ObscuredInt);

	public int MilkReceiveFromLevel => 0;

	public int NumEmptySlot => 0;

	public StarCollabState starCollabState => default(StarCollabState);

	public int Milk => 0;

	public List<UserInfoStarCollab> UserInfoCollabs => null;

	public int GrandReward => 0;

	public RewardState GrandRewardState => default(RewardState);

	public List<UserSimpleInfo> pendings => null;

	public List<UserSimpleInfo> friends => null;

	public List<UserSimpleInfo> suggestions => null;

	private void SaveDataLog()
	{
	}

	protected override void Init()
	{
	}

	private void CompleteLevel()
	{
	}

	public bool IsShowPopup()
	{
		return false;
	}

	public void ConfirmShowPopup()
	{
	}

	public bool IsNoti()
	{
		return false;
	}

	public void ConfirmReceiveMilkFromLevel()
	{
	}

	public bool IsUnLock()
	{
		return false;
	}

	public bool CanShowPopup()
	{
		return false;
	}

	public void CheckState()
	{
	}

	public TimeSpan GetTimeEnd()
	{
		return default(TimeSpan);
	}

	public void ConfirmTutOrStart()
	{
	}

	public int GetMilkReceiveFromPartner()
	{
		return 0;
	}

	public void CheckStateFromServer(SCCheckStarCollab sCCheckStarCollab)
	{
	}

	private int GetTotalScoop()
	{
		return 0;
	}

	private int GetTotalMilestone()
	{
		return 0;
	}

	private void UpdateMilestoneDataLog(int mileStone)
	{
	}

	public void GetStarCollabInfo()
	{
	}

	public TimeSpan GetTimeSpanInviteTeam()
	{
		return default(TimeSpan);
	}

	public int GetPreStateUserCollab(int index)
	{
		return 0;
	}

	public void ConfirmPreScore(int index)
	{
	}

	public void GetStarCollabInfoFromServer(SCGetStarCollabInfo sCGetStarCollabInfo)
	{
	}

	private void CheckLogOpen()
	{
	}

	public void GetSuggestFriend()
	{
	}

	public (List<UserSimpleInfo>, List<UserSimpleInfo>, List<UserSimpleInfo>) GetAllFriendCanInvite(string name)
	{
		return default((List<UserSimpleInfo>, List<UserSimpleInfo>, List<UserSimpleInfo>));
	}

	public void GetSuggestFriendFromServer(SCFriendSuggestStarCollab sCFriendSuggestStarCollab)
	{
	}

	public void InviteFriend(int code)
	{
	}

	public void InviteFriendFromServer(SCInviteFriendStarCollab sCInviteFriendStar)
	{
	}

	private void RemoveUserinfo(int code, List<UserSimpleInfo> userInfos)
	{
	}

	public void ResponRequest(int code, bool accept)
	{
	}

	public void ResponRequestFromServer(SCStarCollabResponseRequest sCStarCollabResponseRequest)
	{
	}

	public void DismissSuggest(int code)
	{
	}

	public void DismissSuggestFromServer(SCDismissSuggestStarCollab sCStarCollabResponseRequest)
	{
	}

	private void ModifyUserCollab()
	{
	}

	public List<ResourceValue> GetResourceProgress(int indexCollab, int indexSlot)
	{
		return null;
	}

	public List<ResourceValue> GetGrandReward()
	{
		return null;
	}

	private List<int> GetTargetPoints()
	{
		return null;
	}

	private float GetProgressRatioByPoint(int score)
	{
		return 0f;
	}

	public float GetProgressRatio(int indexCollab)
	{
		return 0f;
	}

	public float GetPreProgressRatio(int index)
	{
		return 0f;
	}

	public float GetPreProgressRatioInCurrentState(int indexCollab)
	{
		return 0f;
	}

	public RewardState GetRewardState(int collabIndex, int rewardIndex)
	{
		return default(RewardState);
	}

	private int GetRewardIndexPassed(int collabIndex)
	{
		return 0;
	}

	public int GetPreState(int collabIndex)
	{
		return 0;
	}

	public (int, StarCollabLuckyWheelExtraRewardType) GetRewardLuckyWheel(int index)
	{
		return default((int, StarCollabLuckyWheelExtraRewardType));
	}

	public bool CanSpin()
	{
		return false;
	}

	private void InitSpineTYpe()
	{
	}

	private void SaveSpinType()
	{
	}

	private void DeleteSpinType()
	{
	}

	public void Spin(int collabIndex)
	{
	}

	public void SpinFromServer(SCSpinStarCollab sCSpinStarCollab)
	{
	}

	public bool CanClaimGrandReward()
	{
		return false;
	}

	public void ClaimGrandReward()
	{
	}

	public void ClaimGrandRewardFromServer(SCClaimGrandRewadStarCollab sCClaimGrandRewadStarCollab)
	{
	}

	public void ClaimRewardProgress(int collabIndex, int rewardIndex)
	{
	}

	public void ClaimRewardProgressFromServer(SCClaimRewadStarCollab sCClaimRewadStarCollab)
	{
	}

	public int GetTargetScoreRewardProgress(int indexReward)
	{
		return 0;
	}

	public bool CanClaimSomething()
	{
		return false;
	}

	public void ConfirmEnd()
	{
	}

	public void InviteTeamStarCollab()
	{
	}

	public void InviteTeamStarCollabFromServer(SCInviteTeamStarCollab sc)
	{
	}
}
