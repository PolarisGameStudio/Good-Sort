using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Ads Settings", menuName = "Settings/Ads Settings")]
public class AdsSetting : ScriptableObject
{
    // Providers
    [SerializeField] AdMobData adMobContainer;
    public AdMobData AdMobSettings => adMobContainer;
    [Space(20),Header("Tea Brake")]
    public bool useTeaBrake = true;
    public float timeWaitInter = 5;
    public float timeWaitReward = 5;
    [Space(20), Header("Inter splash")]
    public bool useInterSplash = true;
    public bool useOpenAdSplash = false;
    [Space(20), Header("Ads banner Splash")]
    public bool useMrectSplash = true;
    public bool useNativeSplash = false;
    [Space(20), Header("Ads behind inter")]
    public bool useNativeInter = true;
    public bool useOpenAdsInter = false;
    [Space(20), Header("System log")]
    public bool SystemLogs = true;
    public bool isDebug = false;
    public List<string> GetMrectKeyID(MrectType type)
    {
        if (isDebug || AdMobSettings.mrect_extras == null || AdMobSettings.mrect_extras.Count == 0)
        {
#if UNITY_ANDROID

            return new List<string>() { AdMobSettings.banner_id_android };
#else
            return new List<string>() { AdMobSettings.banner_id_ios };
#endif
        }
        var temp = AdMobSettings.mrect_extras.FirstOrDefault(x => x.type == type);
        if (temp != null)
        {
#if UNITY_ANDROID

            return temp.adsKeyID.key_android;
#else
            return temp.adsKeyID.key_ios;
#endif
        }
        return null;
    }
}