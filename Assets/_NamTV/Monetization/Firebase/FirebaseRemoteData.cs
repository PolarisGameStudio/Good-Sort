using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class FirebaseRemoteData
{
    public bool UseInter = true;
    public bool UseReward = true;
    public bool UseOpenAds = true;
    public bool UseSmallBanner = true;
    public bool UseMrecBanner = true;
    public bool UseNative = true;

    [Header("Show ads inter by level X")]
    public int NumShowAdsInterLevel = 2;

    [Header("Time Reload Show ads inter")]
    public int TimeDelayShowAdInter = 25;

    [Header("Use Ads Inter in Splash")]
    public bool IsUseAdsInterSplash = true;

    [Header("Show ads collapse InGame by level X")]
    public int NumShowAdsCollapseInGameLevel = 2;

    [Header("Time Reload Show collap in game")]
    public int TimeReloadCollapse = 30;

    [Header("Turn off Splash in Game")]
    public bool IsDisplaySplashScene = true;

}
