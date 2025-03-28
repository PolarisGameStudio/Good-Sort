using AppsFlyerSDK;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class AdMobHandler : AdvertisingHandler
{
    #region Init
    public AdMobHandler(AdvertisingModules moduleType) : base(moduleType)
    {
    }
    public override void Init(AdsSetting adsSettings)
    {
        isShowingAds = false;
        loadAllAds = false;
        this.adsSettings = adsSettings;
        if (!AdsManager.Instance.isForcedAdEnabled) return;
        if (adsSettings.SystemLogs)
            Debug.Log("[AdsManager]: AdMob is trying to initialize!");
        MobileAds.SetiOSAppPauseOnBackground(true);
        if (AdsManager.Instance.adsProvider != AdvertisingModules.AdMob)
        {
            MobileAds.DisableMediationInitialization();
        }
        MobileAds.Initialize(InitCompleteAction);
    }
    public override void _OnDestroy()
    {
        //AppStateEventNotifier.AppStateChanged -= OnAppStateChanged;
    }
    public override void ForceInitAgain()
    {
        if (!AdsManager.Instance.isForcedAdEnabled) return;
        MobileAds.SetiOSAppPauseOnBackground(true);
        if (AdsManager.Instance.adsProvider != AdvertisingModules.AdMob)
        {
            MobileAds.DisableMediationInitialization();
        }
        MobileAds.Initialize(initStatus =>
        {
            isInitialized = true;
            RequestAllAds();
        });
    }
    private void InitCompleteAction(InitializationStatus initStatus)
    {
        GoogleMobileAds.Common.MobileAdsEventExecutor.ExecuteInUpdate(() =>
        {
            isInitialized = true;
            if (GameFlowHandle.Instance._canUseSplashPopup && GameFlowHandle.Instance.waitSplashLoad)
            {
                if (AdsManager.Instance.UseMrecBanner && adsSettings.useMrectSplash)
                {
                    RequestMrectSplash();
                }
                else if (AdsManager.Instance.UseNative && adsSettings.useNativeSplash)
                {
#if UNITY_EDITOR
                    AdsManager.Instance.stepLoadSplash++;
#endif
                    AdsManager.Instance.RequestNativeSplashCallBack();
                }
                else
                {
                    AdsManager.Instance.stepLoadSplash++;
                }
            }
            else
            {
                AdsManager.Instance.stepLoadSplash++;
            }
            if (AdsManager.Instance.UseInter && adsSettings.useInterSplash)
            {
                FirebaseLogHandle.OnAdsCall("inter_splash", "init_game");
                RequestInterSplash();
            }
            else
            {
                if (AdsManager.Instance.UseOpenAds && adsSettings.useOpenAdSplash)
                {
                    FirebaseLogHandle.OnAdsCall("app_open_splash", "init_game");
                    _HandleRequestOpenAdsSplash();
                }
                else
                {
                    AdsManager.Instance.stepLoadSplash++;
                    RequestAllAds();
                }
            }
        });
    }
    public void RequestAllAds()
    {
        if (loadAllAds) return;
        loadAllAds = true;

        if (AdsManager.Instance.UseOpenAds && adsSettings.AdMobSettings.preloadAdOpen) RequestOpenAds();
        //If use allway pre-load first Inter
        if (AdsManager.Instance.UseInter) RequestInterstitial();

        if (AdsManager.Instance.UseReward && adsSettings.AdMobSettings.preloadReward) RequestRewardedVideo();

        if (AdsManager.Instance.UseMrecBanner && adsSettings.AdMobSettings.preloadMrectDefault) RequestMrectDefaultAds();

        if (AdsManager.Instance.UseSmallBanner) RequestSmallBanner();
    }
    bool loadAllAds = false;
    #endregion
    #region Splash Ads
    public override void ShowInterSplash()
    {
        if (interSplash != null && interSplash.CanShowAd())
        {
            interSplash.Show();
        }
    }
    public override bool IsInterstitialSplashLoaded()
    {
        if(!adsSettings.useInterSplash)
            return false;
        return interSplash != null && interSplash.CanShowAd();
    }
    public override void RequestInterSplash(bool reset = true)
    {
        if (reset)
        {
            interSplashRetry = 0;
        }

        int totalId = 0;
        string adUnitId = "unexpected_platform";
#if UNITY_ANDROID
        if (adsSettings.isDebug)
        {
            adUnitId = adsSettings.AdMobSettings.inter_id_android;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.inter_splash_keyID.key_android.Count <= interSplashRetry) return;
            adUnitId = adsSettings.AdMobSettings.inter_splash_keyID.key_android[interSplashRetry];
            totalId = adsSettings.AdMobSettings.inter_splash_keyID.key_android.Count;
        }

#elif UNITY_IOS
        if (adsSettings.isDebug)
        {
            adUnitId = adsSettings.AdMobSettings.inter_id_ios;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.inter_splash_keyID.key_ios.Count <= interSplashRetry) return;
            adUnitId = adsSettings.AdMobSettings.inter_splash_keyID.key_ios[interSplashRetry];
            totalId = adsSettings.AdMobSettings.inter_splash_keyID.key_ios.Count;
        }
#endif

        if (interSplash != null)
        {
            interSplash.Destroy();
            interSplash = null;
        }
        var adRequest = new AdRequest();

        InterstitialAd.Load(adUnitId.Trim(), adRequest,
            (InterstitialAd ad, LoadAdError error) =>
            {
                // if error is not null, the load request failed.
                if (error != null || ad == null)
                {

                    if (interSplashRetry < totalId - 1)
                    {
                        interSplashRetry++;
                        RequestInterSplash(false);
                    }
                    else
                    {
                        AdsManager.Instance.stepLoadSplash++;
                        RequestAllAds();
                    }

                    return;
                }
                FirebaseLogHandle.OnAdsLoaded("inter_splash", "init_game");
                AdsManager.Instance.stepLoadSplash++;
                interSplash = ad;
                RequestAllAds();
                RegisterInterSplashEventHandlers(interSplash);
            });
    }
    private int interSplashRetry = 0;
    private InterstitialAd interSplash;
    public override void RequestMrectSplash(bool reset = true)
    {
        if (reset)
        {
            mrecOpenRetry = 0;
            FirebaseLogHandle.OnAdsCall("mrect_splash", "init_game");
        }
        int totalId = 0;
        string adUnitId = "unexpected_platform";
#if UNITY_ANDROID
        if (adsSettings.isDebug)
        {
            adUnitId = adsSettings.AdMobSettings.banner_id_android;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.mrec_open_keyID.key_android.Count <= mrecOpenRetry) return;
            adUnitId = adsSettings.AdMobSettings.mrec_open_keyID.key_android[mrecOpenRetry];
            totalId = adsSettings.AdMobSettings.mrec_open_keyID.key_android.Count;
        }

#elif UNITY_IOS
        if (adsSettings.isDebug)
        {
            adUnitId = adsSettings.AdMobSettings.banner_id_ios;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.mrec_open_keyID.key_ios.Count <= mrecOpenRetry) return;
            adUnitId = adsSettings.AdMobSettings.mrec_open_keyID.key_ios[mrecOpenRetry];
            totalId = adsSettings.AdMobSettings.mrec_open_keyID.key_ios.Count;
        }
#endif
        if (mrecOpen != null)
        {
            mrecOpen.Destroy();
            mrecOpen = null;
        }
        if (adsSettings.AdMobSettings.adaptiveMrecOpen)
        {
            AdSize adaptiveSize = AdSize.GetCurrentOrientationAnchoredAdaptiveBannerAdSizeWithWidth(AdSize.FullWidth);
            mrecOpen = new BannerView(adUnitId.Trim(), adaptiveSize, AdPosition.Bottom);
            Debug.Log("[AdsManager]: Mrect open adaptiveSize Width " + adaptiveSize.Width + ", Height" + adaptiveSize.Height);
        }
        else
        {
            mrecOpen = new BannerView(adUnitId.Trim(), AdSize.MediumRectangle, AdPosition.Bottom);
        }
        mrecOpen.OnBannerAdLoaded += () =>
        {
            AdsManager.Instance.stepLoadSplash++;
            FirebaseLogHandle.OnAdsLoaded("mrect_splash", "init_game");
            if (showMrecOpen) mrecOpen.Show();
            else mrecOpen.Hide();
        };
        mrecOpen.OnBannerAdLoadFailed += (LoadAdError error) =>
        {
            if (mrecOpenRetry < totalId - 1)
            {
                mrecOpenRetry++;
                RequestMrectSplash(false);
            }
            else
            {
                AdsManager.Instance.stepLoadSplash++;
            }

        };

        mrecOpen.OnAdPaid += (adValue) => { OnAdPaid("mrect_splash", adValue); };

        AdHelper.SetBannerPos(mrecOpen, adsSettings.AdMobSettings.mrec_open_pos, adsSettings.AdMobSettings.mrec_open_offset);

        AdRequest request = new AdRequest();
        mrecOpen.LoadAd(request);
        mrecOpen.Hide();
    }
    public override void ShowMrecSplash()
    {
        if (!adsSettings.useMrectSplash) return;
        if (!AdsManager.Instance.UseMrecBanner)
        {
            if (mrecOpen != null)
                mrecOpen?.Hide();
            return;
        }
        showMrecOpen = true;
        if (mrecOpen != null)
        {
            AdHelper.SetBannerPos(mrecOpen, adsSettings.AdMobSettings.mrec_open_pos, adsSettings.AdMobSettings.mrec_open_offset);
            mrecOpen?.Show();
        }
        else
        {
            RequestMrectSplash();
        }
    }
    public override void HideMrectSplash()
    {
        if (!adsSettings.useMrectSplash) return;
        showMrecOpen = false;
        if(mrecOpen != null)
        {
            mrecOpen.Hide();
        }
    }
    public override void DestroyMrectSplash()
    {
        if (!adsSettings.useMrectSplash) return;
        showMrecOpen = false;
        if (mrecOpen != null)
        {
            mrecOpen?.Destroy();
            mrecOpen = null;
        }
            
    }
    private void RegisterInterSplashEventHandlers(InterstitialAd ad)
    {
        ad.OnAdFullScreenContentOpened += () =>
        {

#if UNITY_IOS
            hideApp = true;
#endif
            AdsManager.Instance.MuteGameSound();
            FirebaseLogHandle.OnAdsOpened("inter_splash", "init_game");
        };

        ad.OnAdFullScreenContentClosed += () =>
        {
            AdsManager.Instance.ResetInterstitialDelayTime();
            AdsManager.Instance.OpenGameSound();
            isShowingAds = false;
            FirebaseLogHandle.OnAdsShowSuccess("inter_splash", "init_game");
        };

        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            AdsManager.Instance.ResetInterstitialDelayTime();
            AdsManager.Instance.OpenGameSound();
        };

        ad.OnAdPaid += (adValue) => { OnAdPaid("inter_splash", adValue); };
    }
    private bool showMrecOpen;
    private int mrecOpenRetry;
    BannerView mrecOpen;
    public override bool IsOpenAdsSplashLoaded()
    {
        if (!adsSettings.useOpenAdSplash)
            return false;
        return openAdSplash != null && openAdSplash.CanShowAd();
    }
    public override void ShowOpenAdSplash()
    {
        if (openAdSplash != null && openAdSplash.CanShowAd())
        {
            openAdSplash.Show();
        }
    }
    void _HandleRequestOpenAdsSplash(bool reset = true)
    {
        if (reset)
        {
            openAdsSplashRetry = 0;
        }
        int totalId = 0;
        string AD_UNIT_ID = "unexpected_platform";
#if UNITY_ANDROID
        if (adsSettings.isDebug)
        {
            AD_UNIT_ID = adsSettings.AdMobSettings.openad_id_android;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.openad_splash_keyID.key_android.Count <= openAdsSplashRetry) return;
            AD_UNIT_ID = adsSettings.AdMobSettings.openad_splash_keyID.key_android[openAdsSplashRetry];
            totalId = adsSettings.AdMobSettings.openad_splash_keyID.key_android.Count;
        }
#elif UNITY_IOS
        if (adsSettings.isDebug)
        {
            AD_UNIT_ID = adsSettings.AdMobSettings.openad_id_ios;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.openad_splash_keyID.key_ios.Count <= openAdsSplashRetry) return;
            AD_UNIT_ID = adsSettings.AdMobSettings.openad_splash_keyID.key_ios[openAdsSplashRetry];
            totalId = adsSettings.AdMobSettings.openad_splash_keyID.key_ios.Count;
        }
#endif

        // Clean up the old ad before loading a new one.
        if (openAdSplash != null)
        {
            openAdSplash.Destroy();
            openAdSplash = null;
        }

        var adRequest = new AdRequest();

        AppOpenAd.Load(AD_UNIT_ID.Trim(), adRequest,
            (AppOpenAd ad, LoadAdError error) =>
            {
                if (error != null || ad == null)
                {

                    if (openAdsSplashRetry < totalId - 1)
                    {
                        openAdsSplashRetry++;
                        _HandleRequestOpenAdsSplash(false);
                    }
                    else
                    {
                        AdsManager.Instance.stepLoadSplash++;
                        RequestAllAds();
                    }
                    return;
                }
                FirebaseLogHandle.OnAdsLoaded("app_open_splash", "init_game");
                AdsManager.Instance.stepLoadSplash++;
                RequestAllAds();
                openAdSplash = ad;
                RegisterEventOpenAdsSplash(ad);
            });
    }
    void RegisterEventOpenAdsSplash(AppOpenAd ad)
    {
        ad.OnAdFullScreenContentOpened += () =>
        {
            isShowingAppOpen = true;
            AdsManager.Instance.MuteGameSound();
            FirebaseLogHandle.OnAdsOpened("app_open_splash", "init_game");
        };
        ad.OnAdFullScreenContentClosed += () =>
        {
            openAdSplash.Destroy();
            openAdSplash = null;
            isShowingAppOpen = false;
            AdsManager.Instance.OpenGameSound();
            AdsManager.Instance.ResetInterstitialDelayTime();
            FirebaseLogHandle.OnAdsShowSuccess("app_open_splash", "init_game");

        };
        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            openAdSplash.Destroy();
            openAdSplash = null;
        };
        ad.OnAdPaid += (adValue) => { OnAdPaid("app_open_splash", adValue); };
    }
    private AppOpenAd openAdSplash;
    private int openAdsSplashRetry;
    #endregion
    #region Inter
    private InterstitialAd inter;
    private int interDefaultRetry;
    public override bool IsInterstitialLoaded()
    {
        return inter != null && inter.CanShowAd();
    }
    public override void RequestInterstitial(string _placement = "everyWhere")
    {
        _HandleRequestInter(placement: _placement);
    }
    void _HandleRequestInter(bool reset = true, Action _onReady = null, string placement = "everyWhere")
    {
        if (reset)
        {
            interDefaultRetry = 0;
        }
        int totalId = 0;
        string adUnitId = "unexpected_platform";
#if UNITY_ANDROID
        if (adsSettings.isDebug)
        {
            adUnitId = adsSettings.AdMobSettings.inter_id_android;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.inter_keyID.key_android.Count <= interDefaultRetry) return;
            adUnitId = adsSettings.AdMobSettings.inter_keyID.key_android[interDefaultRetry];
            totalId = adsSettings.AdMobSettings.inter_keyID.key_android.Count;
        }

#elif UNITY_IOS
        if (adsSettings.isDebug)
        {
            adUnitId = adsSettings.AdMobSettings.inter_id_ios;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.inter_keyID.key_ios.Count <= interDefaultRetry) return;
            adUnitId = adsSettings.AdMobSettings.inter_keyID.key_ios[interDefaultRetry];
            totalId = adsSettings.AdMobSettings.inter_keyID.key_ios.Count;
        }
#endif

        if (inter != null)
        {
            inter.Destroy();
            inter = null;
        }
        var adRequest = new AdRequest();
        FirebaseLogHandle.OnAdsCall("inter_home",placement);
        InterstitialAd.Load(adUnitId.Trim(), adRequest,
         (InterstitialAd ad, LoadAdError error) =>
         {
             // if error is not null, the load request failed.
             if (error != null || ad == null)
             {
                 if (interDefaultRetry < totalId - 1)
                 {
                     interDefaultRetry++;
                     _HandleRequestInter(false, _onReady);
                 }
                 return;
             }
             inter = ad;
             RegisterEventHandlers(inter, placement);
             _onReady?.Invoke();
             AdsManager.Instance._ExcuteInterLoadedCallBack();
             FirebaseLogHandle.OnAdsLoaded("inter_home", placement);
         });
    }
    private void RegisterEventHandlers(InterstitialAd ad,string placement)
    {
        ad.OnAdFullScreenContentOpened += () =>
        {
#if UNITY_IOS
            hideApp = true;
#endif
            AdsManager.Instance.MuteGameSound();
            FirebaseLogHandle.OnAdsOpened("inter_home", placement);
        };

        ad.OnAdFullScreenContentClosed += () =>
        {
            AdsManager.Instance.CallEventInMainThread(delegate
            {
                isShowingAds = false;
                
                AdsManager.Instance.ResetInterstitialDelayTime();
                AdsManager.Instance.OpenGameSound();
                AdsManager.Instance.ExecuteInterstitialCallback(true);
                if (adsSettings.AdMobSettings.preloadInter) RequestInterstitial();
                AdsManager.Instance._ExcuteInterShowCompleteCallBack();
                FirebaseLogHandle.OnAdsShowSuccess("inter_home", placement);
            });
            
        };

        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            AdsManager.Instance.CallEventInMainThread(delegate
            {
                AdsManager.Instance.ExecuteInterstitialCallback(false);
                AdsManager.Instance.ResetInterstitialDelayTime();
                AdsManager.Instance.OpenGameSound();
                if (adsSettings.AdMobSettings.preloadInter) RequestInterstitial();
                AdsManager.Instance._ExcuteInterShowCompleteCallBack();
            });
            
        };

        ad.OnAdPaid += (adValue) => { OnAdPaid("inter_game", adValue); };
    }
    public override void ShowInterstitial(InterstitialCallback callback, string placement = "everyWhere")
    {
        if (inter != null && inter.CanShowAd())
        {
            isShowingAds = true;
            inter.Show();
            AdsManager.Instance.ResetInterstitialDelayTime();
        }
        else
        {
            if (adsSettings.AdMobSettings.preloadInter)
            {
                RequestInterstitial(placement);
                AdsManager.Instance.ExecuteInterstitialCallback(false);
            }
            else
            {
                if (adsSettings.useTeaBrake)
                {
                    AdsManager.Instance.ResetInterstitialDelayTime();
                    _waitingInter = true;
                    _forceShowInter = false;
                    bool _success = false;
                    UIWaitScreen.Instance._waitForLoading("Time to break!", adsSettings.timeWaitInter,
                        _onStart: () => _HandleRequestInter(_onReady: () =>
                        {
                            _forceShowInter = true;
                            if (_waitingInter)
                            {
                                _success = true;
                                UIWaitScreen.Instance._forceHide();
                                isShowingAds = true;
                                inter.Show();
                                AdsManager.Instance.ResetInterstitialDelayTime();
                            }
                        }, placement : placement),
                        _onComplete: () =>
                        {
                            _waitingInter = false;
                            if (!_forceShowInter)
                            {
                                if (inter != null && inter.CanShowAd())
                                {
                                    _success = true;
                                    isShowingAds = true;
                                    inter.Show();
                                    AdsManager.Instance.ResetInterstitialDelayTime();
                                }
                            }
                            if (!_success)
                            {
                                AdsManager.Instance.ExecuteInterstitialCallback(false);
                            }
                        });

                }
                else
                {
                    AdsManager.Instance.ExecuteInterstitialCallback(false);
                }
            }
        }
    }
    bool _waitingInter = true;
    bool _forceShowInter = false;
    
    #endregion
    #region Reward
    private RewardedAd rewardedAd;
    private int rewardDefaultRetry;
    public override bool IsRewardedVideoLoaded()
    {
        return rewardedAd != null && rewardedAd.CanShowAd();
    }
    public override void RequestRewardedVideo(string _placement = "everyWhere")
    {
        _HandleRequestRewardVideo(placement: _placement);
    }
    void _HandleRequestRewardVideo(bool reset = true, Action _onReady = null, string placement = "everyWhere")
    {
        if (reset)
        {
            rewardDefaultRetry = 0;
        }
        string adUnitId = "unexpected_platform";
        int totalId = 0;
#if UNITY_ANDROID
        if (adsSettings.isDebug)
        {
            adUnitId = adsSettings.AdMobSettings.reward_id_android;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.reward_keyID.key_android.Count <= rewardDefaultRetry) return;
            adUnitId = adsSettings.AdMobSettings.reward_keyID.key_android[rewardDefaultRetry];
            totalId = adsSettings.AdMobSettings.reward_keyID.key_android.Count;
        }
#else
        if (adsSettings.isDebug)
        {
            adUnitId = adsSettings.AdMobSettings.reward_id_ios;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.reward_keyID.key_ios.Count <= rewardDefaultRetry) return;
            adUnitId =  adsSettings.AdMobSettings.reward_keyID.key_ios[rewardDefaultRetry];
            totalId = adsSettings.AdMobSettings.reward_keyID.key_ios.Count;
        }
#endif
        if (rewardedAd != null)
        {
            rewardedAd.Destroy();
            rewardedAd = null;
        }
        FirebaseLogHandle.OnAdsCall("reward_video", placement);
        var adRequest = new AdRequest();

        RewardedAd.Load(adUnitId.Trim(), adRequest,
            (RewardedAd ad, LoadAdError error) =>
            {
                if (error != null || ad == null)
                {
                    if (rewardDefaultRetry < totalId - 1)
                    {
                        rewardDefaultRetry++;
                        _HandleRequestRewardVideo(false, _onReady);
                    }
                    return;
                }
                rewardedAd = ad;
                RegisterEventHandlers(rewardedAd, placement);
                _onReady?.Invoke();
                FirebaseLogHandle.OnAdsLoaded("reward_video", placement);
            });
    }
    private void RegisterEventHandlers(RewardedAd ad, string placement = "everyWhere")
    {
        ad.OnAdFullScreenContentOpened += () =>
        {

#if UNITY_IOS
            hideApp = true;
#endif
            AdsManager.Instance.MuteGameSound();
            FirebaseLogHandle.OnAdsOpened("reward_video", placement);
        };

        ad.OnAdFullScreenContentClosed += () =>
        {
            isShowingAds = false;
            if (adsSettings.AdMobSettings.preloadReward) RequestRewardedVideo();
            AdsManager.Instance.ResetInterstitialDelayTime();
            AdsManager.Instance.OpenGameSound();
            AdsManager.Instance._ExcuteRewardShowCompleteCallBack();
            FirebaseLogHandle.OnAdsShowSuccess("reward_video", placement);
        };

        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            if (adsSettings.AdMobSettings.preloadReward) RequestRewardedVideo();
            AdsManager.Instance.ResetInterstitialDelayTime();
            AdsManager.Instance.OpenGameSound();
            AdsManager.Instance.ExecuteRewardVideoCallback(false);
            AdsManager.Instance._ExcuteRewardShowCompleteCallBack();
        };

        ad.OnAdPaid += (adValue) => { OnAdPaid("reward_video", adValue); };
    }
    public override void ShowRewardedVideo(RewardedVideoCallback callback, string placement = "everyWhere")
    {
        if (rewardedAd != null && rewardedAd.CanShowAd())
        {
            isShowingAds = true;
            rewardedAd.Show((Reward reward) => AdsManager.Instance.ExecuteRewardVideoCallback(true));
        }
        else
        {
            if (adsSettings.AdMobSettings.preloadReward)
            {
                RequestRewardedVideo(placement);
                AdsManager.Instance.ExecuteRewardVideoCallback(false);
            }
            else
            {
                if (adsSettings.useTeaBrake)
                {
                    _waitingReward = true;
                    _forceShowReward = false;
                    bool _success = false;
                    UIWaitScreen.Instance._waitForLoading("Wait a minute!", adsSettings.timeWaitReward,
                        _onStart: () => _HandleRequestRewardVideo(_onReady: () => {
                            _forceShowReward = true;
                            if (_waitingReward)
                            {
                                _success = true;
                                UIWaitScreen.Instance._forceHide();
                                isShowingAds = true;
                                rewardedAd.Show((Reward reward) => AdsManager.Instance.ExecuteRewardVideoCallback(true));
                            }
                        }, placement: placement),
                        _onComplete: () =>
                        {
                            _waitingReward = false;
                            if (!_forceShowReward)
                            {
                                if (rewardedAd != null && rewardedAd.CanShowAd())
                                {
                                    _success = true;
                                    isShowingAds = true;
                                    rewardedAd.Show((Reward reward) => AdsManager.Instance.ExecuteRewardVideoCallback(true));
                                }
                            }
                            if (!_success)
                            {
                                AdsManager.Instance.ExecuteRewardVideoCallback(false);
                            }
                        });
                }
                else
                {
                    AdsManager.Instance.ExecuteRewardVideoCallback(false);
                }
            }
        }
    }
    bool _waitingReward = true;
    bool _forceShowReward = false;
    #endregion
    #region Small banner
    private int smallBannerRetry;
    private BannerView bannerSmall;
    bool isBannerLoaded = false;
    public bool isShowSmallBanner = false;
    public Action _onShowSmallBanner;
    private void RequestSmallBanner()
    {
        _HandleRequestSmallBanner();
    }
    void _HandleRequestSmallBanner(bool reset = true)
    {
        if (reset)
        {
            smallBannerRetry = 0;
        }
        string adUnitId = "unexpected_platform";
        int totalId = 0;
#if UNITY_ANDROID
        if (adsSettings.isDebug)
        {
            adUnitId = adsSettings.AdMobSettings.banner_id_android;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.small_banner_keyID.key_android.Count <= smallBannerRetry) return;
            adUnitId = adsSettings.AdMobSettings.small_banner_keyID.key_android[smallBannerRetry];
            totalId = adsSettings.AdMobSettings.small_banner_keyID.key_android.Count;
        }
#else
        if (adsSettings.isDebug)
        {
            adUnitId = adsSettings.AdMobSettings.banner_id_ios;
            totalId = 3;
        }
        else{
            if (adsSettings.AdMobSettings.small_banner_keyID.key_ios.Count <= smallBannerRetry) return;
            adUnitId = adsSettings.AdMobSettings.small_banner_keyID.key_ios[smallBannerRetry];
            totalId = adsSettings.AdMobSettings.small_banner_keyID.key_ios.Count;
        }
#endif
        isBannerLoaded = false;

        FirebaseLogHandle.OnAdsCall("small_banner", "everyWhere");
        if (bannerSmall != null)
        {
            bannerSmall.Destroy();
            bannerSmall = null;
        }

        if (adsSettings.AdMobSettings.adaptiveBanner)
        {
            AdSize adaptiveSize = AdSize.GetCurrentOrientationAnchoredAdaptiveBannerAdSizeWithWidth(AdSize.FullWidth);
            bannerSmall = new BannerView(adUnitId.Trim(), adaptiveSize, adsSettings.AdMobSettings.small_banner_pos);
        }
        else
        {
            bannerSmall = new BannerView(adUnitId.Trim(), AdSize.Banner, adsSettings.AdMobSettings.small_banner_pos);
        }

        bannerSmall.OnBannerAdLoaded += () =>
        {
            isBannerLoaded = true;
            FirebaseLogHandle.OnAdsLoaded("small_banner", "everyWhere");

#if UNITY_IOS
            SetSmallBannerPos(bannerSmall);
#endif
            if (isShowSmallBanner)
            {
                bannerSmall.Show();
                if (_onShowSmallBanner != null)
                {
                    UnityMainThreadDispatcher.Enqueue(_onShowSmallBanner);
                }
            }
            else bannerSmall.Hide();
        };

        bannerSmall.OnBannerAdLoadFailed += (LoadAdError error) =>
        {
            if (smallBannerRetry < totalId - 1)
            {
                smallBannerRetry++;
                _HandleRequestSmallBanner(false);
            }
        };

        bannerSmall.OnAdPaid += (adValue) => { OnAdPaid("banner_small", adValue); };

        AdRequest request = new AdRequest();
        bannerSmall.LoadAd(request);
        bannerSmall.Hide();
    }
    public override void DestroyBanner()
    {
        isShowSmallBanner = false;
        if (bannerSmall != null)
            bannerSmall.Destroy();
    }
    public override void HideBanner()
    {
        isShowSmallBanner = false;
        if(bannerSmall != null)
            bannerSmall.Hide();
    }
    public override void ShowBanner()
    {
        if (!isInitialized)
            return;
        isShowSmallBanner = true;
        if (bannerSmall == null) return;
        if (_onShowSmallBanner != null)
        {
            UnityMainThreadDispatcher.Enqueue(_onShowSmallBanner);
        }
        if (AdsManager.Instance.isForcedAdEnabled)
        {
#if UNITY_IOS
            SetSmallBannerPos(bannerSmall);
#endif
            bannerSmall?.Show();
        }
        else
        {
            bannerSmall?.Hide();
        }
    }
    public void SetSmallBannerPos(BannerView _banner)
    {
        if (Screen.height != Screen.safeArea.height)
        {
            float screenScale = MobileAds.Utils.GetDeviceScale();
            if (screenScale == 0)
                screenScale = 2.8125f;
            float screenWidth = MobileAds.Utils.GetDeviceSafeWidth();
            if (screenWidth == 0)
                screenWidth = 384;

            float adWidth = (int)(_banner.GetWidthInPixels() / screenScale);
            int xMax = (int)(screenWidth - adWidth);
            int xCenter = (int)(xMax * 0.5f);

            screenWidth *= Screen.width / Screen.safeArea.width;
            float screenHeight = screenWidth / AdHelper.ScreenRatio;


            float adHeight = (int)(_banner.GetHeightInPixels() / screenScale);


            int yMax = (int)(screenHeight - adHeight);
            _banner.SetPosition(xCenter, yMax);
        }
    }
    #endregion
    #region Mrect Default
    private int mrecDefaultRetry;
    private bool showMrecDefault;
    private BannerView mrecDefault;
    public override void RequestMrectDefaultAds()
    {
        if (!adsSettings.AdMobSettings.useMrectDefault) return;
        _HandleRequestMrectDefault();
    }
    void _HandleRequestMrectDefault(bool reset = true)
    {
        if (reset)
        {
            mrecDefaultRetry = 0;
        }
        FirebaseLogHandle.OnAdsCall("mrect_default", "everyWhere");
        int totalId = 0;
        string adUnitId = "unexpected_platform";
#if UNITY_ANDROID
        if (adsSettings.isDebug)
        {
            adUnitId = adsSettings.AdMobSettings.banner_id_android;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.mrec_default_keyID.key_android.Count <= mrecDefaultRetry) return;
            adUnitId = adsSettings.AdMobSettings.mrec_default_keyID.key_android[mrecDefaultRetry];
            totalId = adsSettings.AdMobSettings.mrec_default_keyID.key_android.Count;
        }
#elif UNITY_IOS
        if (adsSettings.isDebug)
        {
            adUnitId = adsSettings.AdMobSettings.banner_id_ios;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.mrec_default_keyID.key_ios.Count <= mrecDefaultRetry) return;
            adUnitId = adsSettings.AdMobSettings.mrec_default_keyID.key_ios[mrecDefaultRetry];
            totalId = adsSettings.AdMobSettings.mrec_default_keyID.key_ios.Count;
        }
#else
        adUnitId = "unexpected_platform";
#endif
        if (mrecDefault != null)
        {
            mrecDefault.Destroy();
            mrecDefault = null;
        }
        if (adsSettings.AdMobSettings.adaptiveMrectDefault)
        {
            AdSize adaptiveSize = AdSize.GetCurrentOrientationAnchoredAdaptiveBannerAdSizeWithWidth(AdSize.FullWidth);
            mrecDefault = new BannerView(adUnitId.Trim(), adaptiveSize, 0, 0);
            Debug.Log("[AdsManager]: Mrect default adaptiveSize = " + adaptiveSize);
        }
        else
        {
            mrecDefault = new BannerView(adUnitId.Trim(), AdSize.MediumRectangle, 0, 0);
        }
        mrecDefault.OnBannerAdLoaded += () =>
        {
            FirebaseLogHandle.OnAdsLoaded("mrect_default", "everyWhere");
            if (showMrecDefault) mrecDefault?.Show();
            else mrecDefault?.Hide();
        };

        mrecDefault.OnBannerAdLoadFailed += (LoadAdError error) =>
        {
            if (mrecDefaultRetry < totalId - 1)
            {
                mrecDefaultRetry++;
                _HandleRequestMrectDefault(false);
            }
        };

        mrecDefault.OnAdPaid += (adValue) => { OnAdPaid("mrect_banner", adValue); };

        AdHelper.SetBannerPos(mrecDefault, adsSettings.AdMobSettings.admob_baner_pos, adsSettings.AdMobSettings.mrec_default_offset);

        AdRequest request = new AdRequest();
        mrecDefault.LoadAd(request);
        mrecDefault.Hide();
    }
    public override void ShowMrecDefault(RectanglePosition showPos = RectanglePosition.None, Vector2Int adPositionOffset = default, string placement = "everyWhere")
    {
        if (!adsSettings.AdMobSettings.useMrectDefault) return;
        showMrecDefault = true;
        if (showPos == RectanglePosition.None) showPos = adsSettings.AdMobSettings.admob_baner_pos;
        if (adPositionOffset == default) adPositionOffset = adsSettings.AdMobSettings.mrec_default_offset;
        if (mrecDefault != null)
        {
            AdHelper.SetBannerPos(mrecDefault, showPos, adPositionOffset);
            mrecDefault.Show();
        }
        else
        {
            RequestMrectDefaultAds();
        }
    }
    public override void HideMrecDefault()
    {
        if (!adsSettings.AdMobSettings.useMrectDefault) return;
        showMrecDefault = false;
        if (mrecDefault != null)
        {
            mrecDefault?.Hide();
        }
    }
    #endregion
    #region Opend Ads
    [HideInInspector] public bool appPause = false;
    [HideInInspector] public bool loadOpenAd = false;
    private bool isShowingAppOpen = false;
    private AppOpenAd openAd;
    private int openAdsRetry;
    bool hideApp = false;
    void RequestOpenAds()
    {
        _HandleRequestOpenAds();
    }
    void _HandleRequestOpenAds(bool reset = true)
    {
        //if (!GameFlowHandle.gameLoaded)
        //{
        //    loadOpenAd = false;
        //    return;
        //}
        if (reset)
        {
            openAdsRetry = 0;
        }
        int totalId = 0;
        string AD_UNIT_ID = "unexpected_platform";
#if UNITY_ANDROID
        if (adsSettings.isDebug)
        {
            AD_UNIT_ID = adsSettings.AdMobSettings.openad_id_android;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.openad_keyID.key_android.Count <= openAdsRetry) return;
            AD_UNIT_ID = adsSettings.AdMobSettings.openad_keyID.key_android[openAdsRetry];
            totalId = adsSettings.AdMobSettings.openad_keyID.key_android.Count;
        }
#elif UNITY_IOS
        if (adsSettings.isDebug)
        {
            AD_UNIT_ID = adsSettings.AdMobSettings.openad_id_ios;
            totalId = 3;
        }
        else
        {
            if (adsSettings.AdMobSettings.openad_keyID.key_ios.Count <= openAdsRetry) return;
            AD_UNIT_ID = adsSettings.AdMobSettings.openad_keyID.key_ios[openAdsRetry];
            totalId = adsSettings.AdMobSettings.openad_keyID.key_ios.Count;
        }
#endif
        FirebaseLogHandle.OnAdsCall("app_open_resume", "everyWhere");
        // Clean up the old ad before loading a new one.
        if (openAd != null)
        {
            openAd.Destroy();
            openAd = null;
        }

        var adRequest = new AdRequest();

        AppOpenAd.Load(AD_UNIT_ID.Trim(), adRequest,
            (AppOpenAd ad, LoadAdError error) =>
            {
                if (error != null || ad == null)
                {

                    if (openAdsRetry < totalId - 1)
                    {
                        openAdsRetry++;
                        _HandleRequestOpenAds(false);
                    }
                    else
                    {
                        loadOpenAd = false;
                    }
                    return;
                }
                FirebaseLogHandle.OnAdsLoaded("app_open_resume", "everyWhere");
                openAd = ad;
                RegisterEventHandlers(ad);
            });
    }
    private void RegisterEventHandlers(AppOpenAd ad)
    {
        ad.OnAdFullScreenContentOpened += () =>
        {
            isShowingAppOpen = true;
            FirebaseLogHandle.OnAdsOpened("app_open_resume", "everyWhere");
        };
        ad.OnAdFullScreenContentClosed += () =>
        {
            openAd.Destroy();
            openAd = null;
            isShowingAppOpen = false;
            loadOpenAd = false;
            GameFlowHandle.Instance.ShowAdsOpenDone();
            if (adsSettings.AdMobSettings.preloadAdOpen) RequestOpenAds();
            FirebaseLogHandle.OnAdsShowSuccess("app_open_resume", "everyWhere");

        };
        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            openAd.Destroy();
            openAd = null;
            loadOpenAd = false;
            GameFlowHandle.Instance.ShowAdsOpenDone();
            if (adsSettings.AdMobSettings.preloadAdOpen) RequestOpenAds();
        };
        ad.OnAdPaid += (adValue) => { OnAdPaid("app_open", adValue); };
    }

    public override void OnAppStateChanged(AppState state)
    {
        if (state == AppState.Background)
        {
            appPause = true;
        }
        if (appPause && state == AppState.Foreground)
        {
            appPause = false;
            if (hideApp)
            {
                hideApp = false;
                return;
            }
            if ((loadOpenAd && !adsSettings.AdMobSettings.preloadAdOpen) || isShowingAppOpen || isShowingAds)
            {
                return;
            }
            if (AdsManager.Instance.UseOpenAds)
            {
                if (adsSettings.AdMobSettings.preloadAdOpen)
                {
                    ShowOpenAds();
                }
                else
                {
                    loadOpenAd = true;
                    GameFlowHandle.Instance.WaitAdsOpen();
                    RequestOpenAds();
                }
            }
        }
    }

    public override void ShowOpenAds()
    {
        if (openAd != null && openAd.CanShowAd())
        {
            openAd.Show();
            AdsManager.Instance.ResetInterstitialDelayTime();
        }
        else
        {
            if (adsSettings.SystemLogs)
                Debug.Log("[AdsManager]: Show openAds failed!");
            if (adsSettings.AdMobSettings.preloadAdOpen) RequestOpenAds();
        }
    }
    public override bool IsOpenAdsReady()
    {
        return openAd != null && openAd.CanShowAd();
    }
    #endregion
    #region Native
    #if USE_ADMOB_NATIVE
    public override void RequestNativeAds(AdmobNativePanel _panel)
    {
        _panel.canShow = false;
        AbmobNativeGroup adsSettingKeyID = adsSettings.AdMobSettings.native_keyID.FirstOrDefault(x => x.type == _panel.admobNativeType);
        if (adsSettingKeyID == null)
            adsSettingKeyID = adsSettings.AdMobSettings.native_keyID[0];
        if (!adsSettingKeyID.forceUse) return;
#if UNITY_IOS
        if (adsSettings.isDebug)
        {
            List<string> _temKey = new List<string>() { adsSettings.AdMobSettings.native_id_ios};
            _panel._HandleRequestNativeAds(_temKey);
        }
        else
        {
            _panel._HandleRequestNativeAds(adsSettingKeyID.adsKeyID.key_ios);
        }
#else
        if (adsSettings.isDebug)
        {
            List<string> _temKey = new List<string>() { adsSettings.AdMobSettings.native_id_android };
            _panel._HandleRequestNativeAds(_temKey);
        }
        else
        {
            _panel._HandleRequestNativeAds(adsSettingKeyID.adsKeyID.key_android);
        }
#endif
    }
#endif
    #endregion
    #region Extra function
    private readonly float microValue = 1000000;

    public override void OnAdPaid(string adType,AdValue adValue)
    {
#if USE_APPSFLYER
        var additionalParams = new Dictionary<string, string>
                        {
                        };
        double _value = (double)adValue.Value / microValue;
        var logRevenue = new AFAdRevenueData("admob", MediationNetwork.GoogleAdMob, adValue.CurrencyCode, _value);
        AppsFlyer.logAdRevenue(logRevenue, additionalParams);
        FirebaseLogHandle.AdsRevenue(adType, adValue.CurrencyCode, _value);
#endif
    }
    
    private bool isShowingAds = false;
    
    #endregion
}