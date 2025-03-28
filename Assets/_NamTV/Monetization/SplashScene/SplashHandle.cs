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
            GameFlowHandle.Instance.LoadSingleScene(loadSceneName);
    }
}
