using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AdvertisingHandler
{
    private AdvertisingModules moduleType;
    public AdvertisingModules ModuleType
    {
        get { return moduleType; }
    }

    protected AdsSetting adsSettings;

    protected bool isInitialized = false;

    public AdvertisingHandler(AdvertisingModules moduleType)
    {
        this.moduleType = moduleType;
    }
    public bool IsInitialized()
    {
        return isInitialized;
    }

    public abstract void Init(AdsSetting adsSettings);
    public abstract void ForceInitAgain();
    public abstract void ShowBanner();
    public abstract void HideBanner();
    public abstract void DestroyBanner();

    public abstract void RequestInterstitial(string placement = "everyWhere");
    public abstract void ShowInterstitial(InterstitialCallback callback, string placement = "everyWhere");
    public abstract bool IsInterstitialLoaded();

    public abstract void RequestRewardedVideo(string placement = "everyWhere");
    public abstract void ShowRewardedVideo(RewardedVideoCallback callback, string placement = "everyWhere");
    public abstract bool IsRewardedVideoLoaded();
    public abstract void DestroyMrectSplash();
    public abstract void ShowMrecSplash();
    public abstract void HideMrectSplash();
    public abstract void RequestMrectSplash(bool reset = true);
    public abstract void RequestInterSplash(bool reset = true);
    public abstract bool IsInterstitialSplashLoaded();
    public abstract void ShowInterSplash();
    public abstract bool IsOpenAdsSplashLoaded();
    public abstract void ShowOpenAdSplash();
    public abstract void RequestMrectDefaultAds();
    public abstract void ShowMrecDefault(RectanglePosition showPos = RectanglePosition.None, Vector2Int adPositionOffset = default, string placement = "everyWhere");
    public abstract void HideMrecDefault();
    public abstract bool IsOpenAdsReady();
    public abstract void ShowOpenAds();
    public abstract void OnAppStateChanged(AppState state);
#if USE_ADMOB_NATIVE
    public abstract void RequestNativeAds(AdmobNativePanel _panel);
#endif
    public abstract void OnAdPaid(string adType, AdValue adValue);
    public abstract void _OnDestroy();
    public delegate void RewardedVideoCallback(bool hasReward);
    public delegate void InterstitialCallback(bool isDisplayed);
}
