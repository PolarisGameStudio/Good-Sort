using Firebase;
using Firebase.Extensions;
using Firebase.RemoteConfig;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class FirebaseHandle : PersistentSingleton<FirebaseHandle>
{
    [SerializeField] FirebaseRemoteData remoteData = new FirebaseRemoteData();
    public FirebaseRemoteData RemoteData => remoteData;
    [Header("DEBUG"), SerializeField]
    public bool logDebug;
    public IEnumerator _DoInit()
    {
        firebaseRemoteLoaded = false;
#if USE_FACEBOOK
        InitFacebook();
#endif
#if USE_FIREBASE
        InitializeFirebaseAndStart();
#else
        //do not init facebook, firebase, remote config
#endif
        yield return new WaitForSeconds(1.5f);

    }
#if USE_FACEBOOK
    private void InitFacebook()
    {
        if (!FB.IsInitialized)
        {
            FB.Init(() =>
            {
                if (logDebug)
                    Debug.Log("[Facebook] Init facebook Completed");
            }, (showGame) => { });
        }
        else FB.ActivateApp();
    }
#endif
    public void InitializeFirebaseAndStart()
    {

        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            var dependencyStatus = task.Result;
            if (dependencyStatus == DependencyStatus.Available)
            {
                FirebaseApp app = FirebaseApp.DefaultInstance;
                if (logDebug)
                    Debug.Log("[Firebase] Init firebase successful");
                FirebaseLogHandle.AnalyticStatus = FirebaseStatus.Initialized;

                InitializeFirebase();
            }
            else
            {
                if (logDebug)
                    Debug.Log("[Firebase] Could not resolve all Firebase dependencies: " + dependencyStatus);
            }
        });
    }
    void InitializeFirebase()
    {
        Dictionary<string, object> defaults = new Dictionary<string, object>
        {
            {"UseInter",RemoteData.UseInter },
            {"UseInter",RemoteData.UseReward },
            {"UseInter",RemoteData.UseOpenAds },
            {"UseInter",RemoteData.UseSmallBanner },
            {"UseInter",RemoteData.UseMrecBanner },
            {"UseInter",RemoteData.UseNative },
        };
        FirebaseRemoteConfig.DefaultInstance.SetDefaultsAsync(defaults);
        FetchFireBase();
    }
    public void FetchFireBase()
    {
        FetchDataAsync();
    }
    public Task FetchDataAsync()
    {
        Task fetchTask = FirebaseRemoteConfig.DefaultInstance.FetchAsync(
            TimeSpan.Zero);
        return fetchTask.ContinueWith(FetchComplete);
    }
    void FetchComplete(Task fetchTask)
    {
        var info = FirebaseRemoteConfig.DefaultInstance.Info;
        switch (info.LastFetchStatus)
        {
            case LastFetchStatus.Success:
                FirebaseRemoteConfig.DefaultInstance.ActivateAsync()
                    .ContinueWith(task => SetAllKeys());
                break;
            case LastFetchStatus.Failure:
                //GameController.Instance.StepLoading();
                switch (info.LastFetchFailureReason)
                {
                    case FetchFailureReason.Error:
                        Debug.Log("[Firebase Remote] Fetch failed for unknown reason");
                        break;
                    case FetchFailureReason.Throttled:
                        Debug.Log("[Firebase Remote] Fetch throttled until " + info.ThrottledEndTime);
                        break;
                }
                break;
            case LastFetchStatus.Pending:
                Debug.Log("[Firebase Remote] Latest Fetch call still pending.");
                break;
            default:
                //GameController.Instance.StepLoading();
                break;
        }
    }
    public void SetAllKeys()
    {
        RemoteData.UseInter = FirebaseRemoteConfig.DefaultInstance.GetValue("UseInter").BooleanValue;
        RemoteData.UseReward = FirebaseRemoteConfig.DefaultInstance.GetValue("UseReward").BooleanValue;
        RemoteData.UseOpenAds = FirebaseRemoteConfig.DefaultInstance.GetValue("UseOpenAds").BooleanValue;
        RemoteData.UseSmallBanner = FirebaseRemoteConfig.DefaultInstance.GetValue("UseSmallBanner").BooleanValue;
        RemoteData.UseMrecBanner = FirebaseRemoteConfig.DefaultInstance.GetValue("UseMrecBanner").BooleanValue;
        RemoteData.UseNative = FirebaseRemoteConfig.DefaultInstance.GetValue("UseNative").BooleanValue;
        if (logDebug)
        {
            Debug.Log("[Firebase] Load remote config success!");
        }
        firebaseRemoteLoaded = true;
    }
    public bool firebaseRemoteLoaded = false;
}
