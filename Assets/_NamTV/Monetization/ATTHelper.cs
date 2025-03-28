using UnityEngine;
using System.Collections;
#if UNITY_IOS
using UnityEngine.iOS;
using Unity.Advertisement.IosSupport;
using System.Runtime.InteropServices;
#endif


#if USE_FACEBOOK && UNITY_IOS && !UNITY_EDITOR
public static class AudienceNetworkSettings
{
    [DllImport("__Internal")]
    private static extern void FBAdSettingsBridgeSetAdvertiserTrackingEnabled(bool advertiserTrackingEnabled);

    public static void SetAdvertiserTrackingEnabled(bool advertiserTrackingEnabled)
    {
        FBAdSettingsBridgeSetAdvertiserTrackingEnabled(advertiserTrackingEnabled);

        Debug.Log("FBAdSettingsBridgeSetAdvertiserTrackingEnabled: " + advertiserTrackingEnabled);
    }
}
#endif

public class ATTHelper : MonoBehaviour
{
    public static bool isAppsFlyerAdRevenueStarted = false;

    [SerializeField] bool checkAtAwake = false;
    private void Awake()
    {
        if (checkAtAwake)
            StartCoroutine(DOCheckATT());
    }

    public static IEnumerator DOCheckATT()
    {
#if UNITY_IOS
        if (ATTrackingStatusBinding.GetAuthorizationTrackingStatus() == ATTrackingStatusBinding.AuthorizationTrackingStatus.NOT_DETERMINED)
        {
            ATTrackingStatusBinding.RequestAuthorizationTracking((status) =>
            {
                var authorizationTrackingStatus = ATTrackingStatusBinding.GetAuthorizationTrackingStatus();
                Debug.LogWarning("[ATTHelper] RequestAuthorizationTracking: " + status + " " + authorizationTrackingStatus);

#if USE_FACEBOOK && !UNITY_EDITOR
                if (authorizationTrackingStatus == ATTrackingStatusBinding.AuthorizationTrackingStatus.AUTHORIZED)
                    AudienceNetworkSettings.SetAdvertiserTrackingEnabled(true);
                else
                    AudienceNetworkSettings.SetAdvertiserTrackingEnabled(false);
#endif
            });
        }
#if !UNITY_EDITOR
        while (ATTrackingStatusBinding.GetAuthorizationTrackingStatus() == ATTrackingStatusBinding.AuthorizationTrackingStatus.NOT_DETERMINED)
            yield return null;
#endif
#endif

#if USE_APPSFLYER && USE_APPSFLYER_CONNECTOR
        if (isAppsFlyerAdRevenueStarted == false)
        {
            AppsFlyerSDK.AppsFlyerAdRevenue.start();
            Debug.Log("[ATTHelper] AppsFlyerAdRevenue Start");
            isAppsFlyerAdRevenueStarted = true;
        }
#endif
        yield return new WaitForSeconds(0.1f);
    }
}
