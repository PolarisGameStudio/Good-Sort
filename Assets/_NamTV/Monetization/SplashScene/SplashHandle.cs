using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Timeline.AnimationPlayableAsset;

public class SplashHandle : MonoBehaviour
{
    [SerializeField] string loadSceneName;
    [SerializeField] List<SplashPopupBase> splashPopupBases = new List<SplashPopupBase>();
    [SerializeField] CanvasGroup emptyCanvas;
    [SerializeField] float timeWaitEmpty = 3f;

    AsyncOperation asyncOperation = null;

    private void Start()
    {
        bool useSplash = false;
        foreach (var item in splashPopupBases)
        {
            if (item._OnInit())
            {
                useSplash = true;
                item._OnClose += OnClose;
                item._OnShow();
                break;
            }
        }
        if (!useSplash)
            StartCoroutine(DelayHide());
        else
        {
            emptyCanvas.alpha = 0;
        }

        if (HelperManager.DataPlayer.LevelID >= 2)
        {
            HelperManager.OnLoadScene(ScStatic.HOME_SCENE, LoadSceneMode.Single, asy => {
                asyncOperation = asy;
            });
        }
        else
        {
            HelperManager.OnLoadGameScene();
        }
    }
    IEnumerator DelayHide()
    {
        emptyCanvas.alpha = 1;
        yield return emptyCanvas.DOFade(0.5f, timeWaitEmpty).WaitForCompletion();
        OnClose();
    }
    private void OnEnable()
    {
        if (GameNativeHandle.Instance != null)
        {
            GameNativeHandle.Instance.ShowMrectBanner();
        }

    }
    private void OnDisable()
    {
        if (GameNativeHandle.Instance != null)
        {
            GameNativeHandle.Instance.HideMrectBanner();
        }
    }
    void OnClose()
    {
        /*if (HelperManager.DataPlayer.dayNumber == 1)
        {
            GameFlowHandle.Instance.LoadSingleScene("DemoCore");
        }
        else*/
         //   GameFlowHandle.Instance.LoadSingleScene(loadSceneName);

        OnLoadScen();
    }


    private void OnLoadScen()
    {
        if (HelperManager.DataPlayer.LevelID < 2)
        {
            HelperManager.ShowGameScene();
        }
        else
        {
            //HelperManager.OnBackHomeScene();
            StartCoroutine(OnShowHOmeScene());
        }
    }

    private IEnumerator OnShowHOmeScene()
    {
        while (true)
        {
            if (asyncOperation != null)
            {
                asyncOperation.allowSceneActivation = true;
                break;
            }

            yield return null;
        }
    }

}
