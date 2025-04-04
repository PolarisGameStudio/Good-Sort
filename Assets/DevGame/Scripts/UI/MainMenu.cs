using DG.Tweening;
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
    [SerializeField] GameObject _fxBlingHard = null;

    [SerializeField] UIReciverItem uIReciverItem = null;

    public SkeletonGraphic skeChes = null;

    [SerializeField] CanvasGroup canvasGroupPop;
    bool isLoadSceneSucess = false;
    bool isLoading = false;
    AsyncOperation callbackScene = null;

    [SerializeField] RectTransform recBtnPlay = null;
 
    [Header("New Items")]
    [SerializeField] Slider loadingSlider = null;
    [SerializeField] TextMeshProUGUI txtLvMin = null;
    [SerializeField] TextMeshProUGUI txtLvMax = null;
    [SerializeField] RectTransform rectAmount = null;
    [SerializeField] UnlockItemGame unlockItemGame = null;


    void Start()
    {
        Audio.PlayBackgroundMusic(ScStatic.MUSIC_HOME);

        GameNativeHandle.Instance?._DelayShowCollab();

        if ((HelperManager.DataPlayer.LevelID) % 5 == 0 && HelperManager.DataPlayer.LevelID > 3)
        {
            _fxBlingHard.gameObject.SetActive(true);
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
        StartCoroutine(OnShowUnlockItem());
        StartCoroutine(OnRunAnimButtonPlay());
    }

    private IEnumerator OnShowUnlockItem()
    {
        int currentId = HelperManager.DataPlayer.LevelID;

        if (currentId > 4)
        {
            var use = ScDataUnlockItemGame.instance.GetDataUseItemByLevel();

            if(use != null)
            {
                var key = "key_show_unlock_" + use.LevelMin + "_" + use.LevelMax;
                if (PlayerPrefs.GetInt(key, 0) == 0)
                {
                    UpdateItem(use, currentId);
                    PlayerPrefs.SetInt(key, 1);
                    List<Sprite> sprites = new();
                    foreach (var it in use.NameItemRemove)
                    {
                        var spr = Resources.Load<Sprite>("Texture2D/newImage/AS_" + it.ToString());
                        sprites.Add(spr);
                    }

                    yield return new WaitForSeconds(0.25f);
                    UIPopup_UnlockRewards.Show();
                    UIPopup_UnlockRewards.Instance.UpdateUISprite();
                    UIPopup_UnlockRewards.Instance.UpdateUI_SkeletonChest_Sprite(skeChes, sprites, 0.01f, 0.425f, 0.25f, () =>
                    {
                        StartCoroutine(OnReciverItem());
                    });
                    yield break;
                }
            }

            StartCoroutine(OnReciverItem());
        }
        else
        {
            StartCoroutine(OnReciverItem());
        }
    }

    private void Update()
    {
        rectAmount.anchoredPosition = new Vector3(305 * loadingSlider.value, 0, 0);
    }

    public IEnumerator OnRunRect(Action callback)
    {
        int index = 0;
        yield return new WaitForEndOfFrame();
        callback?.Invoke();
    }

    public IEnumerator OnReciverItem()
    {
        int currentId = HelperManager.DataPlayer.LevelID;
        var use = ScDataUnlockItemGame.instance.GetDataUseItem();
        UpdateItem(use, currentId);

        yield return new WaitForSeconds(0.25f);

        if (HelperManager.DataPlayer.currentStarGame > 0 || HelperManager.DataPlayer.currentCoin > 0)
        {
            uIReciverItem.gameObject.SetActive(true);
            uIReciverItem.RunAnim();
        }
    }

    void UpdateItem(DataUseItem use, int currentId)
    {
        unlockItemGame.UpdateUi(use);
        txtLvMin.text = (use.LevelMin + 1).ToString();
        txtLvMax.text = (use.LevelMax + 1).ToString();
        float rec = (float)(currentId - use.LevelMin) / (float)(use.LevelMax - use.LevelMin + 1);
        loadingSlider.DOValue(rec, 0.25f).SetEase(Ease.Linear);
    }

    public void RunAnim()
    {
        StartCoroutine(OnReciverItem());
    }    

    private void OnDestroy()
    {
        HelperManager.Save();
    }

    IEnumerator OnRunAnimButtonPlay()
    {
        yield return new WaitForSeconds(0.5f);
        var recTransform = recBtnPlay;

        Sequence buttonSequence = DOTween.Sequence();

        var scale = recTransform.localScale.x;

        buttonSequence.Append(recTransform.DOScale(scale + 0.1f, 0.5f).SetEase(Ease.InOutSine))
                      .Append(recTransform.DOScale(scale, 0.5f).SetEase(Ease.InOutSine))
                      .Append(recTransform.DOScale(scale + 0.05f, 0.5f).SetEase(Ease.InOutSine))
                      .Append(recTransform.DOScale(scale, 0.5f).SetEase(Ease.InOutSine))
                      .SetUpdate(true)
                      .SetLoops(-1, LoopType.Restart);

        buttonSequence.Play();
    }
}
