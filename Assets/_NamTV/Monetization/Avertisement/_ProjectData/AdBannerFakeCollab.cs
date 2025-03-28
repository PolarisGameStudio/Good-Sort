using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdBannerFakeCollab : Singleton<AdBannerFakeCollab>
{
    [SerializeField] AdmobMrectHandle homeBanner;
    [SerializeField] AdmobMrectHandle gameBanner;
    [SerializeField] Button closeBtn;
    [SerializeField] GameObject backGround;
    bool UseMrecBanner =>  AdsManager.Instance.UseMrecBanner;

    private void Start()
    {
        if(closeBtn != null)
        {
            closeBtn.onClick.RemoveAllListeners();
            closeBtn.onClick.AddListener(OnCloseClick);
        }
        _Init();
    }

    private void OnCloseClick()
    {
        _HideBanner();
    }

    void _Init()
    {
        if (UseMrecBanner)
        {
            homeBanner._Init();
            gameBanner._Init();
            homeBanner._onBannerShow += () => { backGround.SetActive(true); };
            gameBanner._onBannerShow += () => { backGround.SetActive(true); };
        }
    }
    bool useHome = false;
    AdmobMrectHandle currentMrect;
    public void _ShowBanner(bool _useHome)
    {
        if (!UseMrecBanner) return;
        if (useHome != _useHome && currentMrect != null)
        {
            backGround.SetActive(false);
            currentMrect.HideBanner();
        }
        useHome = _useHome;
        currentMrect = useHome ? homeBanner : gameBanner;
        currentMrect.ShowBanner();
    }
    public void _HideBanner()
    {
        backGround.SetActive(false);
        if (currentMrect != null)
            currentMrect.HideBanner();
    }
}
