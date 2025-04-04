using Firebase.Analytics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FirebaseLogHandle : MonoBehaviour
{
    private static bool logDebug => FirebaseHandle.Instance.logDebug;
    public static FirebaseStatus AnalyticStatus = FirebaseStatus.Initialing;
    private static readonly string TAG = "[FirebaseLogHandle] ";
    private static readonly string TIME_STAMP = "timeStamp";
    private static readonly string DEVICE_ID = "deviceUniqueIdentifier";
    private static readonly string NETWORK = "network";
    private static readonly string TYPE = "type";
    private static readonly string PLACEMENT = "placement";
    private static readonly string CURRENCY_CODE = "currency_code";
    public static bool isInitiated => AnalyticStatus == FirebaseStatus.Initialized;

    #region Ads
    //Inter
    public static void OnAdsLoaded(string typeAds, string placement = "everyWhere")
    {
        if (!isInitiated) return;
#if USE_FIREBASE
        Parameter[] parameters = new Parameter[]
        {
            new Parameter(PLACEMENT, typeAds),
        };
        SendLog(typeAds + "_loaded", parameters);
        if (logDebug)
            Debug.Log(TAG + typeAds + "_loaded" + " placement " + placement);
#endif
    }
    public static void OnAdsCall(string typeAds, string placement = "everyWhere")
    {
        if (!isInitiated) return;
#if USE_FIREBASE
        Parameter[] parameters = new Parameter[]
        {
            new Parameter(PLACEMENT, typeAds),
        };
        SendLog(typeAds + "_call", parameters);
        if (logDebug)
            Debug.Log(TAG + typeAds + "_call" + " placement " + placement);
#endif
    }
    public static void OnAdsOpened(string typeAds, string placement = "everyWhere")
    {
        if (!isInitiated) return;
#if USE_FIREBASE
        Parameter[] parameters = new Parameter[]
        {
            new Parameter(PLACEMENT, placement),
        };
        SendLog(typeAds + "_opened", parameters);
        if (logDebug)
            Debug.Log(TAG + typeAds + "_opened" + " placement " + placement);
#endif
    }
    public static void OnAdsShowSuccess(string typeAds, string placement = "everyWhere")
    {
        if (!isInitiated) return;
#if USE_FIREBASE
        Parameter[] parameters = new Parameter[]
        {
            new Parameter(PLACEMENT, placement),
        };
        SendLog(typeAds + "_show_success", parameters);
        if (logDebug)
            Debug.Log(TAG + typeAds + "_show_success" + " placement " + placement);
#endif
    }
    public static void AdsRevenue(string typeAds,string currenyCode, double value)
    {
        var temp = new Parameter[] {
                    new Parameter(FirebaseAnalytics.ParameterValue, value),
                    new Parameter(CURRENCY_CODE, currenyCode),
        };
        SendLog(typeAds + "_admob_revenue", temp);
        if (logDebug)
            Debug.Log(TAG + typeAds + "_admob_revenue: " + value);
    }

    //Appflyer
    public static void LogAppflyerTracker(string _status)
    {
        if (!isInitiated) return;
#if USE_FIREBASE

        var param = new Parameter[]
            {
                    new Parameter( "status", _status),
            };

        SendLog("appflyer_tracker", param);
        if (logDebug)
            Debug.Log(TAG + "appflyer_tracker status: " + _status);
#endif
    }
    #endregion

    #region LogEventGame
    #endregion
    private static void SendLog(string logName, Parameter[] param = null)
    {
#if USE_FIREBASE
        try
        {
            List<Parameter> lst = new List<Parameter>();
            if (param != null)
            {
                foreach (Parameter _param in param)
                {
                    lst.Add(_param);
                }
            }
            lst.Add(new Parameter(DEVICE_ID, SystemInfo.deviceUniqueIdentifier));
            lst.Add(new Parameter(TIME_STAMP, DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).Ticks));
            lst.Add(new Parameter(NETWORK, Application.internetReachability.ToString()));

            if (AnalyticStatus == FirebaseStatus.Initialized)
                FirebaseAnalytics.LogEvent(logName, lst.ToArray());
        }
        catch (Exception ex)
        {
            Debug.LogException(ex);
        }
#endif
    }

}
public enum FirebaseStatus
{
    UnAvailable,
    Checking,
    Available,
    Initialing,
    Initialized,
    Getting,
    Completed,
    Faulted,
    Canceled,
    TimeOut,
    NoInternet,
    UnkownError,
    Success,
    Fetching,
    Pending
}