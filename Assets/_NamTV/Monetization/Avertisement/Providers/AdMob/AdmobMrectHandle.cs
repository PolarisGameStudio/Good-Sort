#if USE_ADMOB
using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdmobMrectHandle : MonoBehaviour
{
    public MrectType mrectType = MrectType.collab_home;
    [SerializeField] bool preload = false;
    [SerializeField] bool adaptiveBanner = false;
    [SerializeField] RectanglePosition mrec_pos = RectanglePosition.Bottom;
    [SerializeField] Vector2Int mrec_offset;
    private int mrectBannerRetry;
    private bool showmrectBanner;
    private BannerView mrectBanner;
    bool isLoadBanner = false;
    public void _Init()
    {
        isLoadBanner = false;
        if (preload)
            RequestAds();
    }
    public void RequestAds()
    {
        if (isLoadBanner) return;
        isLoadBanner = true;
        var _ID = AdsManager.Instance.GetAdmobMrectKeyID(mrectType);
        if(_ID == null) return;
        _HandleRequestMrectBanner(_ID);
    }
    void _HandleRequestMrectBanner(List<string> keyID,bool reset = true)
    {
        if (reset)
        {
            mrectBannerRetry = 0;
        }

        int totalId = 0;
        string adUnitId = "unexpected_platform";
        if (keyID.Count <= mrectBannerRetry) return;
        FirebaseLogHandle.OnAdsCall("mrect_" + mrectType);
        adUnitId = keyID[mrectBannerRetry];
        totalId = keyID.Count;

        if (mrectBanner != null)
        {
            mrectBanner.Destroy();
            mrectBanner = null;
        }
        if (adaptiveBanner)
        {
            AdSize adaptiveSize = AdSize.GetCurrentOrientationAnchoredAdaptiveBannerAdSizeWithWidth(AdSize.FullWidth);
            mrectBanner = new BannerView(adUnitId.Trim(), adaptiveSize, 0, 0);
        }
        else
        {
            mrectBanner = new BannerView(adUnitId.Trim(), AdSize.MediumRectangle, 0, 0);
        }
        mrectBanner.OnBannerAdLoaded += () =>
        {
            if (showmrectBanner) _ExcuteShowBanner();
            else mrectBanner?.Hide();
            FirebaseLogHandle.OnAdsLoaded("mrect_" + mrectType);
        };

        mrectBanner.OnBannerAdLoadFailed += (LoadAdError error) =>
        {
            if (mrectBannerRetry < totalId - 1)
            {
                mrectBannerRetry++;
                _HandleRequestMrectBanner(keyID,false);
            }
            else
            {
                isLoadBanner = false;
            }
        };
        isLoadBanner = false;
        mrectBanner.OnAdPaid += (adValue) => { AdsManager.Instance.OnAdPaid("mrect_banner", adValue); };
        AdHelper.SetBannerPos(mrectBanner, mrec_pos, mrec_offset);
        AdRequest request = new AdRequest();
        mrectBanner.LoadAd(request);
        mrectBanner.Hide();
    }
    public void ShowBanner()
    {
        showmrectBanner = true;
        if (mrectBanner != null)
        {
            AdHelper.SetBannerPos(mrectBanner, mrec_pos, mrec_offset);
            _ExcuteShowBanner();
        }
        else
        {
            RequestAds();
        }
    }
    void _ExcuteShowBanner()
    {
        mrectBanner.Show();
        _onBannerShow?.Invoke();
    }
    public void HideBanner()
    {
        showmrectBanner = false;
        if (mrectBanner != null)
        {
            mrectBanner?.Hide();
        }
    }
    public void DestroyBanner()
    {
        showmrectBanner = false;
        if(mrectBanner != null)
        {
            mrectBanner.Destroy();
            mrectBanner = null;
        }
    }
    public Action _onBannerShow;
}
#endif