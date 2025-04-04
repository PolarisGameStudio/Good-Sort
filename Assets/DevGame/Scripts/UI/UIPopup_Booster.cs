using DG.Tweening;
using Firebase.Analytics;
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
}

public class UIPopup_Booster : Dialog<UIPopup_Booster>
{
    [SerializeField] List<UIPopup_Booster_ButtonSelect> uIPopup_Booster_ButtonSelects;
    [SerializeField] List<DataSpriteBossterKind> dataSpriteBossterKinds;

    [SerializeField] Button btnPlayGame;
    [SerializeField] Button btnExit;
    [SerializeField] TextMeshProUGUI txtMesh;
    [SerializeField] TextMeshProUGUI txtLock;

    [SerializeField] SO_Booster sO_Booster;

    Vector3 pointBegin = Vector3.zero;
    private Tween tween;
    private Tween tween1;
    private RectTransform rectToas = null;



    public Action callbackClose;
    public bool isGameScene = false;

    void Start()
    {
        rectToas = txtLock.transform.parent.GetComponent<RectTransform>();
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


            var key_replay_level = "replay_" + HelperManager.DataPlayer.LevelID + 1;
            var value = PlayerPrefs.GetInt(key_replay_level, 0);

            if (value != 0)
            {
               /* Parameter[] lst = new Parameter[]
                  {
                        new Parameter("Level_id_nottool", HelperManager.DataPlayer.LevelID + 1),
                        new Parameter("Level_id_numreplay", value+ 1)
                  };
                FirebaseLogHandle.LogEvent("Level_replay", lst);*/
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

    public void RunActionUnLock(string text)
    {
        txtLock.text = text;

        if (tween1 != null || tween != null)
        {
            tween1.Kill();
            tween.Kill();
            tween = null;
            tween1 = null;
        }

        rectToas.gameObject.SetActive(true);
        rectToas.transform.localScale = Vector3.one * 0.75f;
        var pointSet = pointBegin + new Vector3(0, -150, 0);
        rectToas.anchoredPosition = pointSet;

        float time = 0.25f;

        tween = rectToas.transform.DOScale(1.0f, time).SetEase(Ease.InOutBack);
        tween1 = rectToas.DOAnchorPos(pointBegin, time).SetEase(Ease.InOutQuad).OnComplete(() => {
            StartCoroutine(DisableToas());
        });
    }
    IEnumerator DisableToas()
    {
        yield return new WaitForSeconds(0.25f);
        rectToas.gameObject.SetActive(false);
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
