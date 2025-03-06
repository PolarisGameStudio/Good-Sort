using Cysharp.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : Singleton<MainMenu>
{
    [SerializeField] Button btnSetting;
    [SerializeField] Button btnPlay;
    [SerializeField] Canvas canvas;
    [SerializeField] TextMeshProUGUI txtLevel = null;

    [SerializeField] CanvasGroup canvasGroupPop;
    bool isLoadSceneSucess = false;
    bool isLoading = false;
    AsyncOperation callbackScene = null;

    void Start()
    {
        txtLevel.text = $"Level {HelperManager.DataPlayer.LevelID + 1}";
        ScStatic.SizeCanvas = HelperManager.GetSizeOfCanvas(canvas);
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
