using System;
using Falcon.FalconCore.Scripts.FalconABTesting.Scripts.Model;

[Serializable]
public class RemoteConfig : FalconConfig
{
	public int levelInterstitial;

	public int levelBanner;

	public int levelAppOpen;

	public int levelCellLock;

	public int numPowerupInit;

	public int numBoosterInit;

	public int goldInit;

	public int goldenGiftDayReset;

	public int goldToCreateTeam;

	public int timeAdditionEndgame;

	public string timeActiveCollection;

	public string timeHalloweenEvent;

	public string timeChristmasEvent;

	public string timeSingleDaySale;

	public int levelUnlockSingleDay;

	public string timeBlackFriday;

	public int levelUnlockBlackFriday;

	public int levelIntroChirstmass;

	public int levelUnlockChristmas;

	public int numAdsPowerupPerLevel;

	public int numAdsTimeoutPerLevel;

	public int levelShowIconEventPVP;

	public int levelUnlockEventPVP;

	public int timeToShowReconnectEventPVP;

	public int numHourCooldownWhenFullPiggyBank;

	public int dayNextEndLess2;

	public int shopBundleType;

	public int levelUsingItemSeasonal;

	public int levelUsingThemeSeasonal;

	public int cellLockKind;

	public int goldToUnlockCellLock;

	public string timeSale_12_12;

	public int levelUnlockSale_12_12;

	public int loseWhenQuitLevel;

	public int autoSelectBoosterInfi;

	public int onOffBindData;

	public int onOffDeleteAccount;

	public int onOffFailSafe;

	public int onOffPromoRulesRework;

	public int levelUnLockNewYearEndless;

	public string timeActiveNewYearEndless;

	public string idDevs;

	public int levelUnlockLunarNewYear;

	public int levelIntroLunarNewYear;

	public int timesToChangePole1;

	public int timesToChangePole2;

	public int abLevelFlow => 0;

	public int hintLevel => 0;

	public int GetBgBtnPowerup()
	{
		return 0;
	}
}
