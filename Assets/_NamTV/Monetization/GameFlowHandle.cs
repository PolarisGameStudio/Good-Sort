using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFlowHandle : PersistentSingleton<GameFlowHandle>
{
    [SerializeField] float timeWaitInterOpen = 30f;
    public static bool gameLoaded;
    bool isAcceptUMP = false;
    bool completeInit = false;
    protected WaitForSeconds waitForSeconds = new WaitForSeconds(0.1f);
    bool isLoadingSplash = false;
    float timeWaitSplashCount = 0;
    public bool forceUseSplashPopup = true;
    public bool waitSplashLoad = false;
    [HideInInspector]
    public bool _canUseSplashPopup;
    public bool forceFullAds = false;
    private void Start()
    {
        StartCoroutine(DOInitSDK());
    }
    public IEnumerator DOInitSDK()
    {
        gameLoaded = false;
        isLoadingSplash = false;
        AdsLoading.SetUpdate("Data manager initialize...", 0.05f, 1.5f, true);
        //yield return DataGameManager.instance.InitData();
        yield return waitForSeconds;

        AdsLoading.SetUpdate("Loading-Checking ATT...", 0.1f, 1.5f, true);
        yield return ATTHelper.DOCheckATT();
        yield return waitForSeconds;

        Debug.Log("Firebase Manager initialize...");
        AdsLoading.SetUpdate("Firebase Manager initialize......", 0.15f, 1.5f, true);
        yield return FirebaseHandle.Instance._DoInit();
        yield return waitForSeconds;

        Debug.Log("Firebase Manager getting remote config...");
        AdsLoading.SetUpdate("Firebase manager getting remote config...", 0.20f, 1.5f, true);
        yield return new WaitForSeconds(1.5f);

        _canUseSplashPopup = SplashHelper._CanUseSplashPopup() || forceUseSplashPopup;
        //UMP
        AdsLoading.SetUpdate("Checking UMP...", 0.30f, 1.5f, true);
        yield return UMP.Instance.DOGatherConsent(null);
        isLoadingSplash = true;
        timeWaitSplashCount = 0;
        if (UMP.Instance.CanRequestAds)
        {
            isAcceptUMP = true;
            AdsLoading.SetUpdate("Ads Manager initialize...", 0.7f, timeWaitInterOpen, true);
            AdsManager.Instance.Inititalize();
        }
        GameNativeHandle.Instance._InitOnOpenSession();
        completeInit = true;
    }
    public IEnumerator _InitComplete()
    {
        string nextScene = ScStatic.SPLASH_SCENE;

        if(!_canUseSplashPopup)
        {
            nextScene = HelperManager.DataPlayer.LevelID >= 1 ? ScStatic.HOME_SCENE : ScStatic.GAME_SCENE;
        }

        AdsLoading.SetUpdate("Everything OK!...", 0.9f, 1f, true);
        yield return new WaitForSeconds(1);
        if (AdsManager.Instance.IsInterSplashReady())
        {
            AdsManager.Instance.ShowInterSplash();
        }
        else if(AdsManager.Instance.IsOpenAdSplashReady())
        {
            AdsManager.Instance.ShowOpenAdSplash();
        }
        AdsLoading.SetUpdate("Loading game favorite...", 0.95f, 0.5f, true);
        yield return new WaitForSeconds(0.5f);
        if (_canUseSplashPopup && !waitSplashLoad)
        {
            GameNativeHandle.Instance.RequestNativeSplash();
        }
        //Load splash scene
        AsyncOperation async = null;
        AdsLoading.SetUpdate("Loading game assets...", 1f, 1f, true);
        async = SceneManager.LoadSceneAsync(nextScene, LoadSceneMode.Single);
        if (async == null)
        {
            Debug.Log("Couldn't be loaded because it has not been added to the build settings. To add a scene to the build settings use the menu File->Build Settings...");
            yield break;
        }

        async.allowSceneActivation = false;
        while (async.progress < 0.9f)
        {
            yield return new WaitForSeconds(0.25f);
        }
        async.allowSceneActivation = true;
        while (!async.isDone)
        {
            yield return new WaitForSeconds(0.25f);
        }
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(nextScene));
        
        AdsLoading.HideLoading();
        gameLoaded = true;
        UnityMainThreadDispatcher.Enqueue(GameNativeHandle.Instance._InitOnSplash);  
    }
    private void Update()
    {
        if (isLoadingSplash)
        {
            timeWaitSplashCount += Time.deltaTime;
            if (timeWaitSplashCount < timeWaitInterOpen)
            {
                if (AdsManager.Instance)
                {
                    if (AdsManager.Instance.stepLoadSplash >= 2)
                    {
                        isLoadingSplash = false;
                        StartCoroutine(_InitComplete());
                    }
                }
            }
            else
            {
                isLoadingSplash = false;
                StartCoroutine(_InitComplete());
            }
        }

        if (!gameLoaded) return;
        if (completeInit && !isAcceptUMP)
        {
            if (Application.internetReachability != NetworkReachability.NotReachable)
            {
                isAcceptUMP = true;
                UnityMainThreadDispatcher.Enqueue(UMP.Instance.DOGatherConsent(Helpers.ActionWrapper(() =>
                {
                    AdsManager.Instance.ForceInitAgain();
                })));
            }
        }
    }
    #region open ads
    public void WaitAdsOpen()
    {
        AdsManager adsController = AdsManager.Instance;
        AdsLoading.ShowLoading("Loading... please wait!", adsOpenWaitTime + 2,showAdsBrake:true);

        float temp = 0;
        DOTween.To(() => temp, (x) =>
        {
            //Update
            if (adsController.IsOpenAdsReady())
            {
                AdsLoading.HideLoading();
                Time.timeScale = 0;
                adsController.ShowOpenAds();
            }

        }, adsOpenWaitTime, adsOpenWaitTime);
    }
    public void ShowAdsOpenDone()
    {
        Time.timeScale = 1;
    }
    private readonly float adsOpenWaitTime = 8.6f;
    #endregion

    //Custom
    public void LoadSingleScene(string sceneName)
    {
        StartCoroutine(DoLoadSingleScene(sceneName));
    }
    IEnumerator DoLoadSingleScene(string sceneName)
    {
        yield return new WaitForEndOfFrame();
        AdsLoading.ShowLoading("Gear Up, It’s Game Time!");
        AsyncOperation async = null;
        async = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
        if (async == null)
        {
            Debug.Log("Couldn't be loaded because it has not been added to the build settings. To add a scene to the build settings use the menu File->Build Settings...");
            yield break;
        }
        async.allowSceneActivation = false;
        while (async.progress < 0.9f)
        {
            yield return new WaitForSeconds(0.25f);
        }
        async.allowSceneActivation = true;
        while (!async.isDone)
        {
            yield return new WaitForSeconds(0.25f);
        }
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
        AdsLoading.HideLoading();
    }
}
