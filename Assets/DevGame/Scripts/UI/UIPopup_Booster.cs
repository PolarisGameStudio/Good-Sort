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

    [SerializeField] SO_Booster sO_Booster;


    public Action callbackClose;
    public bool isGameScene = false;

    void Start()
    {
        txtMesh.text = "Level " + (HelperManager.DataPlayer.LevelID + 1).ToString();
        ScStatic.ListBoosterStart.Clear();
        uIPopup_Booster_ButtonSelects[0].SetItemData(dataSpriteBossterKinds[0], sO_Booster.GetDataPowerItem(dataSpriteBossterKinds[0].Kind));
        uIPopup_Booster_ButtonSelects[1].SetItemData(dataSpriteBossterKinds[1], sO_Booster.GetDataPowerItem(dataSpriteBossterKinds[1].Kind));
        uIPopup_Booster_ButtonSelects[2].SetItemData(dataSpriteBossterKinds[2], sO_Booster.GetDataPowerItem(dataSpriteBossterKinds[2].Kind));

        btnPlayGame.onClick.AddListener(() => {

            if(ScStatic.ListBoosterStart.Count > 0)
            {
                foreach(var kin in ScStatic.ListBoosterStart)
                {
                    foreach (var it in uIPopup_Booster_ButtonSelects)
                    {
                        if(kin == it.c_kind)
                        {
                            it.OnAdd();
                        }
                    }
                }
            }

            onClose();
            HelperManager.ShowGameScene();
        });

        btnExit.onClick.AddListener(() => {
            onClose();
            if(isGameScene)
            {
                HelperManager.OnBackHomeScene();
            }    
        });

        HelperManager.OnLoadGameScene();
    }
 

    public void onUpdateBooser(BoosterKind bos, bool isAdd)
    {
        if(isAdd)
        {
            PlayerPrefs.SetInt(bos.ToString(), 1);
            ScStatic.ListBoosterStart.Add(bos);
            return;
        }
        PlayerPrefs.SetInt(bos.ToString(), 0);
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
