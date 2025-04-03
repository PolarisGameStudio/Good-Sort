using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : Singleton<MainMenu>
{
    [SerializeField] Button btnSetting;
    [SerializeField] Button btnPlay;
    [SerializeField] Canvas canvas;
    [SerializeField] TextMeshProUGUI txtLevel = null;
    [SerializeField] TextMeshProUGUI txtStar = null;
    [SerializeField] TextMeshProUGUI txtCoint = null;
    [SerializeField] RectMask2D rectMask = null;

    [SerializeField] UIReciverItem uIReciverItem = null;

    [SerializeField] GameObject _fxBlingNormal = null;
    [SerializeField] GameObject _fxBlingHard = null;
    public SkeletonGraphic skeChes = null;

    [SerializeField] CanvasGroup canvasGroupPop;
    bool isLoadSceneSucess = false;
    bool isLoading = false;
    AsyncOperation callbackScene = null;
    void Start()
    {
        GameNativeHandle.Instance?._DelayShowCollab();
        if ((HelperManager.DataPlayer.LevelID) % 5 == 0 && HelperManager.DataPlayer.LevelID > 3)
        {
            _fxBlingHard.gameObject.SetActive(true);
        }
        else
        {
            _fxBlingNormal.gameObject.SetActive(true);
        }

        txtLevel.text = $"Level {HelperManager.DataPlayer.LevelID + 1}";
        ScStatic.SizeCanvas = HelperManager.GetSizeOfCanvas(canvas);
        btnSetting.onClick.AddListener(() =>
        {
            UI_Setting.Show();
            UI_Setting.Instance.DisableSetting();
        });

        btnPlay.onClick.AddListener(() => {
            Audio.Play(ScStatic.SFX_Button_StartGame);
            UIPopup_Booster.Show();
        });

        txtStar.text = HelperManager.DataPlayer.TotalStar.ToString();
        txtCoint.text = HelperManager.DataPlayer.TotalCoin.ToString();

        //
        OnShowUnlockItem();
    }

    private void OnShowUnlockItem()
    {
        if (HelperManager.DataPlayer.LevelID > 4)
        {
            var use = ScDataUnlockItemGame.instance.GetDataUseItemByLevel();

            if(use != null)
            {
                var key = "key_show_unlock_" + use.LevelMin + "_" + use.LevelMax;
                if (PlayerPrefs.GetInt(key, 0) == 0)
                {
                    PlayerPrefs.SetInt(key, 1);
                    List<Sprite> sprites = new();
                    foreach (var it in use.NameItemRemove)
                    {
                        var spr = Resources.Load<Sprite>("Texture2D/newImage/AS_" + it.ToString());
                        sprites.Add(spr);
                    }
                    UIPopup_UnlockRewards.Show();
                    UIPopup_UnlockRewards.Instance.UpdateUISprite();
                    UIPopup_UnlockRewards.Instance.UpdateUI_SkeletonChest_Sprite(skeChes, sprites, 0.01f, 0.425f, 0.25f, () =>
                    {
                        StartCoroutine(OnReciverItem());
                    });
                    return;
                }
            }    

            StartCoroutine(OnReciverItem());
        }
        else
        {
            StartCoroutine(OnReciverItem());
        }
    }

    public IEnumerator OnRunRect(Action callback)
    {
        int index = 0;
  /*      while(index < 100000)
        {
            index += 200;
            if(index > 30000)
            {
                txtStar.gameObject.SetActive(false);
                txtCoint.gameObject.SetActive(false);
                txtLevel.transform.parent.transform.parent.gameObject.SetActive(false);

            }
            rectMask.softness = new Vector2Int(index, index); 
            yield return null;
        }*/
        
        yield return new WaitForEndOfFrame();

        callback?.Invoke();
    }

    public IEnumerator OnReciverItem()
    {
        yield return new WaitForSeconds(0.25f);

        if (HelperManager.DataPlayer.currentStarGame > 0 || HelperManager.DataPlayer.currentCoin > 0)
        {
            uIReciverItem.gameObject.SetActive(true);
            uIReciverItem.RunAnim();
        }
    }

    public void RunAnim()
    {
        StartCoroutine(OnReciverItem());
    }    

    private void OnDestroy()
    {
        HelperManager.Save();
    }
}
