using System;
using CodeStage.AntiCheat.ObscuredTypes;

public class RemoveAdsController : NMSingleton<RemoveAdsController>
{
	public ObscuredInt GOLD_WHEN_PURCHASE;

	private const string key = "remove_ads";

	private ObscuredInt _state;

	private bool _isShow;

	private bool _isOpenRemoveAdsMenu;

	private int _countShowInterstitial;

	public const int NUM_INTERSTITIAL_TO_SHOW_REMOVEADS = 3;

	public Action onPurchase;

	public int State => 0;

	protected override void Init()
	{
	}

	private void InitData()
	{
	}

	public void SetDataToDefault()
	{
	}

	public bool CanShowPopup()
	{
		return false;
	}

	public bool CanShowRemoveAdsAfterInterstitialEndGame()
	{
		return false;
	}

	public void ResetIsOpenRemoveAdsMenu()
	{
	}

	public void IncreaseCountShowInterstitial(bool isOpenRemoveAdsMenu = false)
	{
	}

	public void ShowPopup()
	{
	}

	private void Save()
	{
	}

	public TimeSpan GetTimeExprice()
	{
		return default(TimeSpan);
	}

	public bool IsRemove()
	{
		return false;
	}

	public string GetPrice()
	{
		return null;
	}

	public void Purchase()
	{
	}

	public void Restore()
	{
	}

	public void UpdateDataFromServer(int state)
	{
	}
}
