using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameNativeHandle : MonoBehaviour
{
    [SerializeField] AdmobNativePanel nativeSplash;
    [SerializeField] AdmobNativePanel nativeDefault;
    [SerializeField] AdmobNativePanel nativeInter;
    [SerializeField] AdmobNativePanel nativeCollab;
    [SerializeField] GameObject nativeSplashParent;
    [SerializeField] List<GameObject> nativeParent = new List<GameObject>();

    [Header("For native splash")]
    [SerializeField] Vector2 offsetFullAds = Vector2.zero;
    [SerializeField] List<Transform> splashChildSort = new List<Transform>();
    [SerializeField] BoxCollider2D slpashFakeCollider;
    [SerializeField] Image bgNativeSplash;
    [SerializeField] Color bgNativeColor = Color.white;
    [SerializeField] RectTransform callToActionBtn;
    private bool UseNativeBanner => AdsManager.Instance.UseNative;
    public bool useOrganic => AppFlyerHelper.Instance.useOrganic && !GameFlowHandle.Instance.forceFullAds;
    public static GameNativeHandle Instance;
    int showNativeCollabCount;
    bool collabClicked = false;
    bool isInitiated = false;
    bool saveMrectSplash = false;
    private void Start()
    {
        ShowNativeSplash(false);
        if (UseNativeBanner && AdsManager.Instance.AdsSetting.useNativeSplash)
        {
            AdsManager.Instance._OnRequestNativeSplashAds += () =>
            {
                RequestNativeSplash();
            };
            nativeSplash._OnNativeClick += () =>
            {
                RequestNativeSplash();
            };
            nativeSplash._OnRequireReload += () =>
            {
                RequestNativeSplash();
            };
            nativeSplash._OnNativeLoaded += () =>
            {
                AdsManager.Instance.stepLoadSplash++;
            };

        }
    }
    public void ShowNativeSplash(bool show)
    {
        Vector2 offset = Vector2.zero;
        if (useOrganic)
        {
            int index = 0;
            foreach (var item in splashChildSort)
            {
                item.SetSiblingIndex(index);
                index++;
            }
            bgNativeSplash.color = bgNativeColor;
            callToActionBtn.sizeDelta = new Vector2(callToActionBtn.sizeDelta.x, 120);
        }
        else
        {
            int index = splashChildSort.Count - 1;
            foreach (var item in splashChildSort)
            {
                item.SetSiblingIndex(index);
                index--;
            }
            offset = offsetFullAds;
            bgNativeSplash.color = Color.white;
            callToActionBtn.sizeDelta = new Vector2(callToActionBtn.sizeDelta.x, 180);
        }
        slpashFakeCollider.offset = offset;
        nativeSplashParent.SetActive(show);
    }
    public void RequestNativeSplash()
    {
        if (AdsManager.Instance.AdsSetting.useNativeSplash)
        {
            if (nativeSplash.isLoading) return;
            AdsManager.Instance.RequestNativeAds(nativeSplash);
        }
        else if(AdsManager.Instance.AdsSetting.useMrectSplash)
        {
            if(saveMrectSplash) return;
            saveMrectSplash = true;
            AdsManager.Instance.RequestMrectSplash();
        }
    }
    public void _InitOnOpenSession()
    {
        if (UseNativeBanner)
        {
            collabClicked = false;
            showNativeCollabCount = 0;
            //nativeDefault._OnNativeLoaded += () =>
            //{
            //    UnityMainThreadDispatcher.Enqueue(() =>
            //    {
            //        _EnqueueNative(NativePriority.Banner);
            //    });
            //};
            nativeDefault._OnNativeClick += () =>
            {
                nativeDefault.useFakeCollider = false;
                RequestNativeDefault();
            };
            nativeDefault._OnRequireReload += () =>
            {
                RequestNativeDefault();
            };
            
            nativeCollab._OnNativeLoaded += () =>
            {
                UnityMainThreadDispatcher.Enqueue(() =>
                {
                    showNativeCollabCount++;
                    _EnqueueNative(NativePriority.Collab);
                });
            };
            nativeCollab._OnNativeClick += () =>
            {
                collabClicked = true;
                nativeCollab.OnClose();
            };
            nativeCollab._OnNativeClose += () =>
            {
                _DequeueNative(NativePriority.Collab);
            };
            
        }
        isInitiated = true;
    }
    public void _InitOnSplash()
    {
        _InitNativeInter();
    }
    public void _InitOnHome() 
    {
        if(UseNativeBanner)
        {
            _EnqueueNative(NativePriority.Banner);
            _InitNativeInter();
            RequestNativeDefault();
        }
    }
    bool nativeInterInitiated = false;
    public void _InitNativeInter()
    {
        if (useOrganic) return;
        if (nativeInterInitiated) return;
        FirebaseLogHandle.LogAppflyerTracker("init_success");
        nativeInterInitiated = true;
        if (UseNativeBanner && AdsManager.Instance.AdsSetting.useNativeInter)
        {
            RequestNativeInter();
            AdsManager.Instance._OnInterShowComplete += () =>
            {
                if (nativeInter.canShow)
                {
                    _EnqueueNative(NativePriority.Inter);
                }
            };
            nativeInter._OnNativeClose += () =>
            {
                AdsManager.Instance.ResetInterstitialDelayTime();
                _DequeueNative(NativePriority.Inter);
                RequestNativeInter();
            };
            nativeInter._OnNativeClick += () =>
            {
                nativeInter.OnClose();
            };
        }
        else if (AdsManager.Instance.AdsSetting.useOpenAdsInter)
        {
            AdsManager.Instance._OnInterShowComplete += () =>
            {
                AdsManager.Instance.ShowOpenAds();
            };
            AdsManager.Instance._OnRewardShowComplete += () =>
            {
                AdsManager.Instance.ShowOpenAds();
            };
        }
    }
    public void _DelayShowCollab()
    {
        if (!isInitiated) return;
        UnityMainThreadDispatcher.Enqueue(DeLayShowNativeCollab());
    }
    IEnumerator DeLayShowNativeCollab()
    {
        yield return new WaitForSeconds(1.618f);
        ExcuteShowNativeCollab();
    }
    void ExcuteShowNativeCollab()
    {
        if (!UseNativeBanner) return;
        nativeCollab.useFakeCollider = !collabClicked && (showNativeCollabCount >= 1);
        if (!nativeCollab.canShow && !nativeCollab.isLoading)
            AdsManager.Instance.RequestNativeAds(nativeCollab);
    }
    void _EnqueueNative(NativePriority _nativePriority)
    {
        if (nativePriorities.Contains(_nativePriority)) return;
        nativePriorities.Add(_nativePriority);
        nativePriorities.Sort();
        _ExcuteShowNative();
    }
    void _DequeueNative(NativePriority _nativePriority)
    {
        if (nativePriorities.Count == 0) return;
        UnityMainThreadDispatcher.Enqueue(() =>
        {
            nativePriorities.Remove(_nativePriority);
            nativeParent[(int)_nativePriority].SetActive(false);
            _ExcuteShowNative();
        });
    }
    void _ExcuteShowNative()
    {
        if (nativePriorities.Count == 0) return;
        for (int index = 0; index < nativeParent.Count; index++)
        {
            nativeParent[index].SetActive(index == (int)nativePriorities.Last());
        }
    }
    List<NativePriority> nativePriorities = new List<NativePriority>();
    void RequestNativeInter()
    {
        AdsManager.Instance.RequestNativeAds(nativeInter);
    }
    void RequestNativeDefault()
    {
        AdsManager.Instance.RequestNativeAds(nativeDefault);
    }
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void ShowMrectBanner()
    {
        if (AdsManager.Instance.AdsSetting.useMrectSplash)
        {
            AdsManager.Instance.ShowMrectSplash();
        }
        else if (AdsManager.Instance.AdsSetting.useNativeSplash)
        {
            ShowNativeSplash(true);
        }
    }
    public void HideMrectBanner()
    {
        if (AdsManager.Instance.AdsSetting.useMrectSplash)
        {
            AdsManager.Instance.HideMrectSplash();
        }
        else if (AdsManager.Instance.AdsSetting.useNativeSplash)
        {
            ShowNativeSplash(false);
        }
    }
}
