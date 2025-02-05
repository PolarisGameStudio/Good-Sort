using System;
using System.Collections.Generic;
using MagicExcel;

public class MasterPassController : NMSingleton<MasterPassController>
{
	public enum Theme
	{
		None = 0,
		Thanksgiving = 1,
		Christmas = 2,
		LunarNewYear = 3,
		Spring = 4
	}

	public const int frame_id = -1;

	private const string key = "master_pass_0";

	private const int level_unlock = 24;

	private MasterPass _masterPass;

	private int _numReward;

	private Theme _theme;

	private Theme _preThemeWhenEnd;

	public Action OnReset;

	public Action OnClaim;

	private const string Item_Type = "masster_pass";

	public Action OnBuyPremium;

	private bool isBuyPremiumInGame;

	public MasterPass MasterPass => null;

	public int NumReward => 0;

	public int GetMaxLive => 0;

	public Theme CurrentTheme => default(Theme);

	public bool IsBuyPremiumInGame => false;

	public string GetPopupNameByTheme()
	{
		return null;
	}

	public string GetPopupEndedNameByTheme()
	{
		return null;
	}

	private void CheckTheme()
	{
	}

	protected override void Init()
	{
	}

	private void OnChangeScene(SceneState state)
	{
	}

	private void CompleteLevel()
	{
	}

	public (bool, List<ResourceValue>) CheckTime()
	{
		return default((bool, List<ResourceValue>));
	}

	public void ClaimResourceEndSession()
	{
	}

	private List<ResourceValue> GetResourcesCanClaimEndSession()
	{
		return null;
	}

	public void Reset()
	{
	}

	public TimeSpan GetTimeEnd()
	{
		return default(TimeSpan);
	}

	private void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void ValidateData()
	{
	}

	private void Save()
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public bool IsShowTut()
	{
		return false;
	}

	public void ShowTutDone()
	{
	}

	public bool IsMax()
	{
		return false;
	}

	public int GetPreIndexRewardPassed(bool isHome)
	{
		return 0;
	}

	public int GetIndexRewardPassed()
	{
		return 0;
	}

	public int GetPreIndexRewardTarget(bool isHome)
	{
		return 0;
	}

	public int GetIndexRewardTarget()
	{
		return 0;
	}

	private int GetIndexRewardTarget(int key)
	{
		return 0;
	}

	private int GetCurrentIndexReward(int key)
	{
		return 0;
	}

	private int GetIndexRewardPassed(int key)
	{
		return 0;
	}

	public int GetPreKeyInProgress(bool isHome)
	{
		return 0;
	}

	public int GetCurrentKeyInProgress()
	{
		return 0;
	}

	public int GetKeyTaret()
	{
		return 0;
	}

	private int GetKeyRequire(int index)
	{
		return 0;
	}

	public MasterPassAnimUpdateKey GetMasterPassAnimUpdateKey(bool isHome)
	{
		return null;
	}

	public bool IsShowAnimUpdateKey()
	{
		return false;
	}

	public bool IsShowAnimUpdateKeyHome()
	{
		return false;
	}

	public void ConfirmNextKeyHome()
	{
	}

	public void ConfirmNextKey()
	{
	}

	public (ChestType?, List<ResourceValue>) GetResources(int index, int type)
	{
		return default((ChestType?, List<ResourceValue>));
	}

	private (ChestType?, List<ResourceValue>) GetResources(int index, int chestType, EncryptedInt[] rewardType, EncryptedInt[] rewardValue)
	{
		return default((ChestType?, List<ResourceValue>));
	}

	public RewardState GetRewardState(int index, int type)
	{
		return default(RewardState);
	}

	public void Claim(int index, int type)
	{
	}

	public string GetPremiumPrice()
	{
		return null;
	}

	public void BuyPremium()
	{
	}

	public bool IsBuyPremium()
	{
		return false;
	}

	public bool IsShowInShop()
	{
		return false;
	}

	public bool IsShowInEndGame()
	{
		return false;
	}

	public void ConfirmBuyPremiumInGame()
	{
	}

	public void ResetBuyPremiumInGame()
	{
	}

	public void UpdateDataFromServer(MasterPassServer masterPass)
	{
	}
}
