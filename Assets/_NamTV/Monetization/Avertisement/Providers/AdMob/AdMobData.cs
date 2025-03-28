using GoogleMobileAds.Api;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[Serializable]
public class AdMobData
{
    //banner_id_android: ca-app-pub-3940256099942544/6300978111
    //inter_id_android: ca-app-pub-3940256099942544/1033173712
    //reward_id_android: ca-app-pub-3940256099942544/5224354917
    //openad_id_android: ca-app-pub-3940256099942544/3419835294
    //native_id_android: ca-app-pub-3940256099942544/2247696110

    //banner_id_ios: ca-app-pub-3940256099942544/2934735716
    //inter_id_ios: ca-app-pub-3940256099942544/4411468910
    //reward_id_ios: ca-app-pub-3940256099942544/1712485313
    //openad_id_ios: ca-app-pub-3940256099942544/5662855259
    //native_id_ios: ca-app-pub-3940256099942544/3986624511
    public readonly string banner_id_android = "ca-app-pub-3940256099942544/6300978111";
    public readonly string inter_id_android = "ca-app-pub-3940256099942544/1033173712";
    public readonly string reward_id_android = "ca-app-pub-3940256099942544/5224354917";
    public readonly string openad_id_android = "ca-app-pub-3940256099942544/9257395921";
    public readonly string native_id_android = "ca-app-pub-3940256099942544/2247696110";
    public readonly string banner_id_ios = "ca-app-pub-3940256099942544/2934735716";
    public readonly string inter_id_ios = "ca-app-pub-3940256099942544/4411468910";
    public readonly string reward_id_ios = "ca-app-pub-3940256099942544/1712485313";
    public readonly string openad_id_ios = "ca-app-pub-3940256099942544/5662855259";
    public readonly string native_id_ios = "ca-app-pub-3940256099942544/3986624511";

    [Header("INTER open")]
    [SerializeField] public AdsSettingKeyID inter_splash_keyID;

    [Space(15), Header("MREC OPEN")]
    [SerializeField] public bool adaptiveMrecOpen = false;
    [SerializeField] public RectanglePosition mrec_open_pos = RectanglePosition.Bottom;
    [SerializeField] public Vector2Int mrec_open_offset;
    [SerializeField] public AdsSettingKeyID mrec_open_keyID;

    [Space(15), Header("OPEN ADS Splash")]
    [SerializeField] public AdsSettingKeyID openad_splash_keyID;

    [Space(15),Header("OPEN ADS")]
    [SerializeField] public bool preloadAdOpen = false;
    [SerializeField] public AdsSettingKeyID openad_keyID;

    [Space(15),Header("ADMOB INTER")]
    [SerializeField] public bool preloadInter = false;
    [SerializeField] public AdsSettingKeyID inter_keyID;

    [Space(15),Header("ADMOB REWARD")]
    [SerializeField] public bool preloadReward = false;
    [SerializeField] public AdsSettingKeyID reward_keyID;

    [Space(15),Header("SMALL BANNER")]
    [SerializeField] public bool adaptiveBanner = false;
    [SerializeField] public AdPosition small_banner_pos = AdPosition.Bottom;
    [SerializeField] public AdsSettingKeyID small_banner_keyID;

    [Space(15),Header("MREC DEFAULT")]
    [SerializeField] public bool useMrectDefault = true;
    [SerializeField] public bool preloadMrectDefault = true;
    [SerializeField] public bool adaptiveMrectDefault = false;
    [SerializeField] public RectanglePosition admob_baner_pos = RectanglePosition.Bottom;
    [SerializeField] public Vector2Int mrec_default_offset;
    [SerializeField] public AdsSettingKeyID mrec_default_keyID;

    [Space(15), Header("MREC Extra")]
    public List<AbmobMrectGroup> mrect_extras = new List<AbmobMrectGroup>();

    [Space(15), Header("ADMOB NATIVE")]
    [SerializeField] public List<AbmobNativeGroup> native_keyID = new List<AbmobNativeGroup>();  
}
[Serializable]
public enum AdmobNativeType
{
    Default = 0,
    Collab = 1,
    Inter = 2,
    Home = 3,
    Splash = 4,
}
[Serializable]
public class AbmobNativeGroup
{
    public AdmobNativeType type;
    public bool forceUse = true;
    public AdsSettingKeyID adsKeyID;
}
[Serializable]
public class AbmobMrectGroup
{
    public MrectType type;
    public AdsSettingKeyID adsKeyID;
}
[Serializable]
public enum NativePriority
{
    Banner,
    Collab,
    Inter
}

[Serializable]
 public enum MrectType
{
    collab_home,
    collab_game,
}