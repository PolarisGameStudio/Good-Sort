using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AdsManager : PersistentSingleton<AdsManager>
{

	private MediationBase _mediation;

	public Action<bool> OnVideoAvailableChanged;

	public static Action onWatchReward;

	public static Action onNoRewardAdsToShow;

	private bool includePlacement;

	public Action OnBannerLoaded;

	public static bool isPauseByWebView;

	private DateTime timePause;

	private int level => 0;

	public bool IsAppOpenAdAvailable => false;

	protected override void Awake()
	{
	}

	public void Init()
	{
	}

	public void ShowInterstitialAd(Action callback, AdIntersType type)
	{
	}

	public bool IsInterstitialAdsAvailable()
	{
		return false;
	}

	public void ShowRewardedAds(Action<bool> callback, AdRewardType kind)
	{
	}

	public bool CanShowReward()
	{
		return false;
	}

	public void HideBanner()
	{
	}

	public void ShowBanner(AdBannerType adBannerType)
	{
	}

	public bool IsBannerReady()
	{
		return false;
	}

	public void SetupRectPanelAds(RectTransform rectPanelAds, RectTransform rectButtonRemoveAds)
	{
	}

	public void ForceUnCheckTimePause(int minute)
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	public void ChekAndShowAppOpen()
	{
	}

	private IEnumerator DelayShowAppOpenAd()
	{
		return null;
	}

	public void ShowAppOpenAd()
	{
	}
}
