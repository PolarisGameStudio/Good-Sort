using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[Serializable]
public struct DataSpriteBossterKind
{
    public BoosterKind Kind;
    public Sprite sprEnable;
    public Sprite sprDisable;
}

public class UIPopup_Booster : Dialog<UIPopup_Booster>
{
    [SerializeField] List<UIPopup_Booster_ButtonSelect> uIPopup_Booster_ButtonSelects;
    [SerializeField] List<DataSpriteBossterKind> dataSpriteBossterKinds;

    [SerializeField] Button btnPlayGame;
    [SerializeField] Button btnExit;
    [SerializeField] TextMeshProUGUI txtMesh;
    public Action callbackClose;

    void Start()
    {
        txtMesh.text = "Level " + (HelperManager.DataPlayer.LevelID + 1).ToString();
        ScStatic.ListBoosterStart.Clear();
        uIPopup_Booster_ButtonSelects[0].SetItemData(dataSpriteBossterKinds[0]);
        uIPopup_Booster_ButtonSelects[1].SetItemData(dataSpriteBossterKinds[1]);
        uIPopup_Booster_ButtonSelects[2].SetItemData(dataSpriteBossterKinds[2]);

        btnPlayGame.onClick.AddListener(() => {
            onClose();
            HelperManager.ShowGameScene();
        });

        btnExit.onClick.AddListener(() => {
            onClose();
        });

        HelperManager.OnLoadGameScene();
    }
 

    public void onUpdateBooser(BoosterKind bos, bool isAdd)
    {
        if(isAdd)
        {
            ScStatic.ListBoosterStart.Add(bos);
            return;
        }
        ScStatic.ListBoosterStart.Remove(bos);
    }

    public static void Show()
    {
        Open();
    }
    public static void Hide()
    {
        Close(Instance.callbackClose);
    }

    public void onClose()
    {
        Hide();
    }
}
