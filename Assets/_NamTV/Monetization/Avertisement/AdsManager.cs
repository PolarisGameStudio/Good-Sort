using DG.Tweening;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// GoogleMobileAds-v8.6.0
public class AdsManager : MonoBehaviour
{
    #region Properties
    [SerializeField] public AdvertisingModules adsProvider = AdvertisingModules.AdMob;
    [SerializeField] private AdsSetting settings;
    public AdsSetting AdsSetting => settings;
    private static AdvertisingHandler[] advertisingModules = new AdvertisingHandler[]
        {
            new AdMobHandler(AdvertisingModules.AdMob), // AdMob module
        };
    private static Dictionary<AdvertisingModules, AdvertisingHandler> advertisingActiveModules = new Dictionary<AdvertisingModules, AdvertisingHandler>();
    public bool isForcedAdEnabled = true;
    public float InterstitialShowingDelay = 15f;
    //Remote Config
    public bool UseMrecBanner => FirebaseHandle.Instance ? FirebaseHandle.Instance.RemoteData.UseMrecBanner : false;
    public bool UseInter => FirebaseHandle.Instance ? FirebaseHandle.Instance.RemoteData.UseInter : false;
    public bool UseReward => FirebaseHandle.Instance ? FirebaseHandle.Instance.RemoteData.UseReward : false;
    public bool UseOpenAds => FirebaseHandle.Instance ? FirebaseHandle.Instance.RemoteData.UseOpenAds : false;
    public bool UseSmallBanner => FirebaseHandle.Instance ? FirebaseHandle.Instance.RemoteData.UseSmallBanner : false;
    public bool UseNative => FirebaseHandle.Instance ? FirebaseHandle.Instance.RemoteData.UseNative : false;

    public int stepLoadSplash = 0;
    private static AdvertisingHandler.RewardedVideoCallback rewardedVideoCallback;
    private static AdvertisingHandler.InterstitialCallback interstitalCallback;
    public delegate bool IsAdsReadyCallback();
    #endregion
    #region Base setting
    public static AdsManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        
    }
    private void Start()
    {
        AppStateEventNotifier.AppStateChanged += OnAppStateChanged;
    }
    protected virtual void OnApplicationQuit()
    {
        Instance?.StopAllCoroutines();
        Instance = null;
        Destroy(gameObject);
    }
    protected virtual void OnDestroy()
    {
        Instance?.StopAllCoroutines();
        Instance = null;
        foreach (var advertisingModule in advertisingActiveModules.Keys)
        {
            advertisingActiveModules[advertisingModule]._OnDestroy();
        }
        AppStateEventNotifier.AppStateChanged -= OnAppStateChanged;
    }
    public void OnAppStateChanged(AppState state)
    {
        foreach (var advertisingModule in advertisingActiveModules.Keys)
        {
            advertisingActiveModules[advertisingModule].OnAppStateChanged(state);
        }
    }
    #endregion
    #region Init
    public void Inititalize()
    {
        stepLoadSplash = 0;
        // Validate
        ExtraInterstitialReadyConditions += CheckInterstitialTime;
        ResetInterstitialDelayTime();
        advertisingActiveModules = new Dictionary<AdvertisingModules, AdvertisingHandler>();
        for (int i = 0; i < advertisingModules.Length; i++)
        {
            if (IsModuleEnabled(advertisingModules[i].ModuleType))
            {
                advertisingActiveModules.Add(advertisingModules[i].ModuleType, advertisingModules[i]);
            }
        }
        foreach (var advertisingModule in advertisingActiveModules.Keys)
        {
            InitModule(advertisingModule);
        }
    }
    private void InitModule(AdvertisingModules advertisingModule)
    {
        if (advertisingActiveModules.ContainsKey(advertisingModule))
        {
            if (settings.SystemLogs)
                Debug.Log("[AdsManager]: Module " + advertisingModule.ToString() + " trying to initialize!");

            advertisingActiveModules[advertisingModule].Init(settings);
        }
        else
        {
            if (settings.SystemLogs)
                Debug.LogWarning("[AdsManager]: Module " + advertisingModule.ToString() + " is disabled!");
        }
    }
    public bool IsModuleEnabled(AdvertisingModules advertisingModule)
    {
        if (advertisingModule == AdvertisingModules.Disable)
            return false;
        return true;
    }
    public static bool IsModuleActive(AdvertisingModules advertisingModule)
    {
        return advertisingActiveModules.ContainsKey(advertisingModule);
    }
    public static bool IsModuleInititalized(AdvertisingModules advertisingModule)
    {
        if (advertisingActiveModules.ContainsKey(advertisingModule))
        {
            return advertisingActiveModules[advertisingModule].IsInitialized();
        }

        return false;
    }
    public void ForceInitAgain()
    {
        if (!isForcedAdEnabled)
            return;

        if (!IsModuleActive(adsProvider))
            return;

        if (advertisingActiveModules[adsProvider].IsInitialized())
            return;

        advertisingActiveModules[adsProvider].ForceInitAgain();
    }
    #endregion
    #region Splash Ads
    public bool IsInterSplashReady()
    {
        return IsInterstitialSplashLoaded(adsProvider);
    }
    public void ShowInterSplash()
    {
        if (!isForcedAdEnabled)
        {
            return;
        }
        if (!UseInter)
        {
            return;
        }
        if (!IsModuleActive(adsProvider))
        {
            return;
        }
        advertisingActiveModules[adsProvider].ShowInterSplash();
    }
    public void RequestMrectSplash()
    {
        RequestMrectSplash(adsProvider);
    }
    public void RequestMrectSplash(AdvertisingModules advertisingModules)
    {
        if (!isForcedAdEnabled)
        {
            return;
        }
        if (!UseMrecBanner)
        {
            return;
        }
        if (!IsModuleActive(advertisingModules))
        {
            return;
        }
        if (advertisingActiveModules[advertisingModules].IsInterstitialSplashLoaded())
            return;
        advertisingActiveModules[advertisingModules].RequestMrectSplash();
    }
    public void ShowMrectSplash()
    {
        if (!isForcedAdEnabled)
        {
            return;
        }
        if (!UseMrecBanner)
        {
            return;
        }
        if (!IsModuleActive(adsProvider))
        {
            return;
        }
        advertisingActiveModules[adsProvider].ShowMrecSplash();
    }
    public void HideMrectSplash()
    {
        if (!isForcedAdEnabled)
        {
            return;
        }
        if (!UseMrecBanner)
        {
            return;
        }
        if (!IsModuleActive(adsProvider))
        {
            return;
        }
        advertisingActiveModules[adsProvider].HideMrectSplash();
    }
    public void DestroyMrectSplash()
    {
        if (!isForcedAdEnabled)
        {
            return;
        }
        if (!UseMrecBanner)
        {
            return;
        }
        if (!IsModuleActive(adsProvider))
        {
            return;
        }
        advertisingActiveModules[adsProvider].DestroyMrectSplash();
    }
    public bool IsInterstitialSplashLoaded(AdvertisingModules advertisingModules)
    {
        if (!isForcedAdEnabled)
            return false;

        if (!IsModuleActive(advertisingModules))
            return false;

        return advertisingActiveModules[advertisingModules].IsInterstitialSplashLoaded();
    }
    public bool IsOpenAdSplashReady()
    {
        return IsOpenAdSplashReady(adsProvider);
    }
    public bool IsOpenAdSplashReady(AdvertisingModules advertisingModules)
    {
        if (!isForcedAdEnabled)
            return false;

        if (!IsModuleActive(advertisingModules))
            return false;

        return advertisingActiveModules[advertisingModules].IsOpenAdsSplashLoaded();
    }

    public void ShowOpenAdSplash()
    {
        ShowOpenAdSplash(adsProvider);
    }
    public void ShowOpenAdSplash(AdvertisingModules advertisingModules)
    {
        if (!isForcedAdEnabled)
        {
            return;
        }
        if (!AdsSetting.useOpenAdSplash)
        {
            return;
        }
        if (!IsModuleActive(adsProvider))
        {
            return;
        }
        advertisingActiveModules[adsProvider].ShowOpenAdSplash();
    }
    #endregion
    #region Inter
    public bool IsInterstitialLoaded()
    {
        return IsInterstitialLoaded(adsProvider);
    }
    public bool IsInterstitialLoaded(AdvertisingModules advertisingModules)
    {
        if (!isForcedAdEnabled)
            return false;

        if (!IsModuleActive(advertisingModules))
            return false;

        return advertisingActiveModules[advertisingModules].IsInterstitialLoaded();
    }
    public void RequestInterstitial(string placement = "everyWhere")
    {
        RequestInterstitial(adsProvider, placement);
    }
    public void RequestInterstitial(AdvertisingModules advertisingModules, string placement = "everyWhere")
    {
        if (!isForcedAdEnabled)
            return;
        if(!UseInter)
            return;

        if (!IsModuleActive(advertisingModules))
            return;

        //if (advertisingActiveModules[advertisingModules].IsInterstitialLoaded())
        //    return;

        advertisingActiveModules[advertisingModules].RequestInterstitial(placement);
    }
    public void ShowInterstitial(AdvertisingHandler.InterstitialCallback callback, string placement = "everyWhere")
    {
        ShowInterstitial(adsProvider, callback,placement);
    }
    public void ShowInterstitial(AdvertisingModules advertisingModules, AdvertisingHandler.InterstitialCallback callback, string placement = "everyWhere")
    {
        interstitalCallback = callback;

        if (!isForcedAdEnabled)
        {
            ExecuteInterstitialCallback(false);

            return;
        }

        if (!IsModuleActive(advertisingModules))
        {
            ExecuteInterstitialCallback(false);

            return;
        }
        if (!UseInter)
        {
            ExecuteInterstitialCallback(false);

            return;
        }

        if (!CheckExtraInterstitialCondition())
        {
            ExecuteInterstitialCallback(false);

            return;
        }
        if (!advertisingActiveModules[advertisingModules].IsInitialized())
        {
            ExecuteInterstitialCallback(false);
            return;
        }
        if (!settings.useTeaBrake && !advertisingActiveModules[advertisingModules].IsInterstitialLoaded())
        {
            ExecuteInterstitialCallback(false);
            //_ExcuteInterShowCompleteCallBack();
            return;
        }

        advertisingActiveModules[advertisingModules].ShowInterstitial(callback, placement);
    }
    public void ExecuteInterstitialCallback(bool result)
    {
        if (interstitalCallback != null)
        {
            CallEventInMainThread(() => interstitalCallback.Invoke(result));
        }
    }
    public bool CheckExtraInterstitialCondition()
    {
        if (ExtraInterstitialReadyConditions != null)
        {
            bool state = true;

            System.Delegate[] listDelegates = ExtraInterstitialReadyConditions.GetInvocationList();
            for (int i = 0; i < listDelegates.Length; i++)
            {
                if (!(bool)listDelegates[i].DynamicInvoke())
                {
                    state = false;

                    break;
                }
            }

            if (settings.SystemLogs)
                Debug.Log("[AdsManager]: Extra condition interstitial state: " + state);

            return state;
        }

        return true;
    }
    private bool CheckInterstitialTime()
    {
        if (settings.SystemLogs)
            Debug.Log("[AdsManager]: Interstitial Time: " + lastInterstitialTime + "; Time: " + TimeUtils.GetCurrentUnixTimestamp());

        return lastInterstitialTime < TimeUtils.GetCurrentUnixTimestamp();
    }
    public void ResetInterstitialDelayTime()
    {
        lastInterstitialTime = TimeUtils.GetCurrentUnixTimestamp() + InterstitialShowingDelay;
    }
    private double lastInterstitialTime;
    public IsAdsReadyCallback ExtraInterstitialReadyConditions;
    #endregion
    #region Reward
    public bool IsRewardBasedVideoLoaded()
    {
        return IsRewardBasedVideoLoaded(adsProvider);
    }
    public bool IsRewardBasedVideoLoaded(AdvertisingModules advertisingModules)
    {
        if(!isForcedAdEnabled)
            return false;
        if (!IsModuleActive(advertisingModules))
            return false;

        return advertisingActiveModules[advertisingModules].IsRewardedVideoLoaded();
    }
    public void RequestRewardBasedVideo(string placement = "everyWhere")
    {
        RequestRewardBasedVideo(adsProvider,placement);
    }

    public void RequestRewardBasedVideo(AdvertisingModules advertisingModules, string placement = "everyWhere")
    {
        if (!isForcedAdEnabled)
            return;
        if (!IsModuleActive(advertisingModules))
            return;
        if (!UseReward)
            return;
        //if (advertisingActiveModules[advertisingModules].IsRewardedVideoLoaded())
        //    return;

        advertisingActiveModules[advertisingModules].RequestRewardedVideo(placement);
    }
    public void ShowRewardBasedVideo(AdvertisingHandler.RewardedVideoCallback callback, string placement = "everyWhere")
    {
        ShowRewardBasedVideo(adsProvider, callback,placement);
    }
    public void ShowRewardBasedVideo(AdvertisingModules advertisingModules, AdvertisingHandler.RewardedVideoCallback callback, string placement = "everyWhere")
    {
        rewardedVideoCallback = callback;
        waitingForRewardVideoCallback = true;

        if (!IsModuleActive(advertisingModules))
        {
            ExecuteRewardVideoCallback(false);
            return;
        }
        if (!UseReward)
        {
            ExecuteRewardVideoCallback(false);
            return;
        }
        if (!advertisingActiveModules[advertisingModules].IsInitialized())
        {
            ExecuteRewardVideoCallback(false);
            return;
        }
        if (!settings.useTeaBrake && !advertisingActiveModules[advertisingModules].IsRewardedVideoLoaded())
        {
            ExecuteRewardVideoCallback(false);
            return;
        }
        advertisingActiveModules[advertisingModules].ShowRewardedVideo(callback,placement);
    }
    public void ExecuteRewardVideoCallback(bool result)
    {
        if (rewardedVideoCallback != null && waitingForRewardVideoCallback)
        {
            CallEventInMainThread(() => rewardedVideoCallback.Invoke(result));

            waitingForRewardVideoCallback = false;

            if (settings.SystemLogs)
            {
                Debug.Log("[AdsManager]: Reward received: " + result);
            }
        }
    }
    private static bool waitingForRewardVideoCallback;
    #endregion
    #region Small Banner
    public void ShowSmallBanner()
    {
        ShowSmallBanner(adsProvider);
    }

    public void ShowSmallBanner(AdvertisingModules advertisingModules)
    {
        if (!isForcedAdEnabled)
            return;

        if (!IsModuleActive(advertisingModules))
            return;
        if (!GameFlowHandle.gameLoaded || !UseSmallBanner)
        {
            advertisingActiveModules[advertisingModules].HideBanner();
            return;
        }
        if (!CheckExtraBannerCondition())
            return;

        advertisingActiveModules[advertisingModules].ShowBanner();
    }

    public void DestroyBanner()
    {
        DestroyBanner(adsProvider);
    }

    public void DestroyBanner(AdvertisingModules advertisingModules)
    {
        if (!IsModuleActive(advertisingModules))
            return;
        if (!UseSmallBanner) return;
        advertisingActiveModules[advertisingModules].DestroyBanner();
    }

    public void HideSmallBanner()
    {
        HideSmallBanner(adsProvider);
    }

    public void HideSmallBanner(AdvertisingModules advertisingModules)
    {
        if (!IsModuleActive(advertisingModules))
            return;
        if (!UseSmallBanner) return;
        advertisingActiveModules[advertisingModules].HideBanner();
    }

    public bool CheckExtraBannerCondition()
    {
        if (ExtraBannerReadyConditions != null)
        {
            bool state = true;

            System.Delegate[] listDelegates = ExtraBannerReadyConditions.GetInvocationList();
            for (int i = 0; i < listDelegates.Length; i++)
            {
                if (!(bool)listDelegates[i].DynamicInvoke())
                {
                    state = false;

                    break;
                }
            }

            if (settings.SystemLogs)
                Debug.Log("[AdsManager]: Extra condition banner state: " + state);

            return state;
        }

        return true;
    }
    public static IsAdsReadyCallback ExtraBannerReadyConditions;
    #endregion
    #region Mrect Default
    public void RequestMrectDefaultAds()
    {
        RequestMrectDefaultAds(adsProvider);
    }
    public void RequestMrectDefaultAds(AdvertisingModules advertisingModules)
    {
        if (!UseMrecBanner)
        {
            return;
        }
        if (!IsModuleActive(advertisingModules))
        {
            return;
        }
        if (!advertisingActiveModules[advertisingModules].IsInitialized())
        {
            return;
        }
        advertisingActiveModules[advertisingModules].RequestMrectDefaultAds();
    }
    public void ShowMrectDefault(RectanglePosition showPos = RectanglePosition.None,Vector2Int adPositionOffset = default, string placement = "everyWhere")
    {
        ShowMrectDefault(adsProvider, showPos, adPositionOffset,placement);
    }
    public void ShowMrectDefault(AdvertisingModules advertisingModules, RectanglePosition showPos = RectanglePosition.None, Vector2Int adPositionOffset = default, string placement = "everyWhere")
    {
        if (!isForcedAdEnabled)
        {
            return;
        }
        if(!GameFlowHandle.gameLoaded || !UseMrecBanner)
        {
            advertisingActiveModules[advertisingModules].HideMrecDefault();
            return;
        }
        if (!IsModuleActive(advertisingModules))
        {
            return;
        }

        advertisingActiveModules[advertisingModules].ShowMrecDefault(showPos,adPositionOffset,placement);
    }
    public void HideMrectDefault()
    {

        HideMrectDefault(adsProvider);
    }
    public void HideMrectDefault(AdvertisingModules advertisingModules)
    {
        if (!UseMrecBanner)
        {
            return;
        }
        if (!IsModuleActive(advertisingModules))
        {
            return;
        }
        if (!advertisingActiveModules[advertisingModules].IsInitialized())
        {
            return;
        }
        advertisingActiveModules[advertisingModules].HideMrecDefault();
    }
    #endregion
    #region Mrect Extra
#if USE_ADMOB
    public List<string> GetAdmobMrectKeyID(MrectType mrectType)
    {
        if (!UseMrecBanner)
        {
            return null;
        }
        if (!IsModuleActive(adsProvider))
        {
            return null;
        }
        if (!advertisingActiveModules[adsProvider].IsInitialized())
        {
            return null;
        }
        return AdsSetting.GetMrectKeyID(mrectType);
    }
#endif
    #endregion
    #region Native
    #if USE_ADMOB_NATIVE
    public void RequestNativeAds(AdmobNativePanel _panel = null)
    {
        RequestNativeAds(adsProvider,_panel);
    }
    public void RequestNativeAds(AdvertisingModules advertisingModule, AdmobNativePanel _panel = null)
    {
        if (!isForcedAdEnabled)
            return;
        if (!UseNative)
            return;

        if (!IsModuleActive(advertisingModule))
            return;

        if (!advertisingActiveModules[advertisingModule].IsInitialized())
        {
            return;
        }

        advertisingActiveModules[advertisingModule].RequestNativeAds(_panel);
    }
    public void RequestNativeSplashCallBack()
    {
        _OnRequestNativeSplashAds?.Invoke();
    }

    #endif
    #endregion
    #region Opend Ads
    public bool IsOpenAdsReady()
    {
        return IsOpenAdsReady(adsProvider);
    }
    public bool IsOpenAdsReady(AdvertisingModules advertisingModules)
    {
        if (!isForcedAdEnabled)
            return false;
        if (!UseOpenAds)
            return false;
        if (!IsModuleActive(advertisingModules))
            return false;
        return advertisingActiveModules[advertisingModules].IsOpenAdsReady();
    }
    public void ShowOpenAds()
    {
        ShowOpenAds(adsProvider);
    }
    public void ShowOpenAds(AdvertisingModules advertisingModules)
    {
        if (!isForcedAdEnabled)
            return;
        if (!UseOpenAds)
            return;
        if (!IsModuleActive(advertisingModules))
            return;
        advertisingActiveModules[advertisingModules].ShowOpenAds();
    }
    #endregion
    #region Main Thread
    public void CallEventInMainThread(SimpleCallback callback)
    {
        if (callback != null)
        {
            mainThreadEvents.Add(new MainThreadEvent(callback));
            mainThreadEventsCount++;
        }
    }
    private void Update()
    {
        if (mainThreadEventsCount > 0)
        {
            for (int i = 0; i < mainThreadEventsCount; i++)
            {
                mainThreadEvents[i].Callback?.Invoke();
            }

            mainThreadEvents.Clear();
            mainThreadEventsCount = 0;
        }
    }
    private List<MainThreadEvent> mainThreadEvents = new List<MainThreadEvent>();
    private int mainThreadEventsCount;
    #endregion
    #region Excute when ads showing
    public void MuteGameSound()
    {
        SetVolumeFade(0, 0.25f);
        Time.timeScale = 0;
    }
    public void OpenGameSound()
    {
        Time.timeScale = 1f;
        SetVolumeFade(1f, 1f);
    }
    public static void SetVolumeFade(float endValue, float duration)
    {
        Debug.Log("[AdsManager] " + "SetVolumeFade");
        DOTween.Kill("SetVolumeFade", true);
        var volume = AudioListener.volume;
        DOVirtual.Float(volume, endValue, duration, (v) =>
        {
            AudioListener.volume = v;
        })
        .SetId("SetVolumeFade")
        .SetUpdate(true);
    }
    public void OnAdPaid(string typeAd,AdValue adValue)
    {
        if (!IsModuleActive(adsProvider))
            return;
        advertisingActiveModules[adsProvider].OnAdPaid(typeAd,adValue);
    }
    #endregion
    #region Callback
    public SimpleCallback _OnInterLoaded,_OnInterShowComplete, _OnRewardShowComplete, _OnRequestNativeSplashAds;
    public void _ExcuteInterLoadedCallBack()
    {
        CallEventInMainThread(() => _OnInterLoaded?.Invoke());
    }
    public void _ExcuteInterShowCompleteCallBack()
    {
        CallEventInMainThread(() => _OnInterShowComplete?.Invoke());
        //_OnInterShowComplete?.Invoke();
    }
    public void _ExcuteRewardShowCompleteCallBack()
    {
        CallEventInMainThread(() => _OnRewardShowComplete?.Invoke());
        //_OnRewardShowComplete?.Invoke();
    }

    #endregion
}
