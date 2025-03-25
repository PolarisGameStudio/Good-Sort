using Cysharp.Threading.Tasks.Linq;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;


public class UILoadingCanvas : MonoBehaviour
{
    [SerializeField] private Image imgSlide;
    [SerializeField] TextMeshProUGUI textMesh = null;
    [SerializeField] RectTransform objBgImg = null;
    [SerializeField] Canvas canvas = null;

    float SizeObj = 0.0f;

    public float CountCurrent = 0f;
    float countLoading = 0f;
    float max = 0;

    AsyncOperation asyncOperation = null;

    void Start()
    {
        ScStatic.SizeCanvas = HelperManager.GetSizeOfCanvas(canvas);
        CountCurrent = 0f;
        SizeObj = objBgImg.sizeDelta.x - 50;
        imgSlide.fillAmount = 0;
        StartCoroutine(SetTextLoading());

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

    IEnumerator SetTextLoading()
    {
        List<string> txtLoading = new List<string>() { "Loading", "Loading.", "Loading..", "Loading..." };

        int inndex = 0;

        while(true)
        {
            textMesh.text = txtLoading[inndex % txtLoading.Count];
            inndex++;
            yield return null;
            yield return new WaitForSeconds(0.25f);
            yield return new WaitForEndOfFrame();
        }
    }    

    public void SetSlide(float val)
    {
        imgSlide.fillAmount = val;
    }
    public void SetPercentLoad(float per)
    {
        if(per > 100.0f)
        {
            per = 100;
        }
    }

    public void AutoLoad(float time)
    {
        countLoading += time;
    }

    bool isLoading = false;

    private void Update()
    {
      //  max = Mathf.Max(max, AdsLoading.instance.precent);
        max += Time.deltaTime * 0.25f;
        SetSlide(max);
        if(max >= 0.99f && !isLoading)
        {
            isLoading = true;
            OnLoadScen();
        }

        /*if (CountCurrent <= 1.0f)
        {
            objBus.anchoredPosition = new Vector2(SizeObj * imgSlide.fillAmount, objBus.anchoredPosition.y);
        }*/
    }

    private void OnLoadScen()
    {
        if(HelperManager.DataPlayer.LevelID < 2)
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
        while(true)
        {
            if(asyncOperation != null)
            {
                asyncOperation.allowSceneActivation = true;
                break;
            }

            yield return null;
        }
    }

}
