using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeShowAdsNativeInGame : MonoBehaviour
{
    public static TimeShowAdsNativeInGame instance;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public bool IsResetAds = false;

    private double lastNativeInGameTime;

    public void ResetInterstitialDelayTime()
    {
        if(IsResetAds)
        {
            lastNativeInGameTime = TimeUtils.GetCurrentUnixTimestamp() + AdsManager.Instance.TimeReloadCollapse;
        }
    }

    public bool CheckInterstitialTime()
    {
        var value = lastNativeInGameTime < TimeUtils.GetCurrentUnixTimestamp();
        Debug.Log("[AdsManager]: nativeInGame Time: " + lastNativeInGameTime + "; Time: " + TimeUtils.GetCurrentUnixTimestamp() + "_value_:" + value);
        return value;
    }

    private void Start()
    {
        lastNativeInGameTime = TimeUtils.GetCurrentUnixTimestamp() + AdsManager.Instance.TimeReloadCollapse;
    }
}
