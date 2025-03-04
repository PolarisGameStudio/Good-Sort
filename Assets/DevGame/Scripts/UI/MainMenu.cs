using Cysharp.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : Singleton<MainMenu>
{
    [SerializeField] Button btnSetting;
    [SerializeField] Button btnPlay;

    [SerializeField] CanvasGroup canvasGroupPop;
    bool isLoadSceneSucess = false;
    bool isLoading = false;
    AsyncOperation callbackScene = null;

    void Start()
    {
        btnSetting.onClick.AddListener(() =>
        {
            UI_Setting.Show();
        });

        btnPlay.onClick.AddListener(() => {
            UIPopup_Booster.Show();
        });
       
    }

    private void OnDestroy()
    {
        HelperManager.Save();
    }
}
