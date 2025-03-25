using Coffee.UIExtensions;
using Cysharp.Threading.Tasks;
using System;
using System.Collections;
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

    [SerializeField] CanvasGroup canvasGroupPop;
    bool isLoadSceneSucess = false;
    bool isLoading = false;
    AsyncOperation callbackScene = null;
    void Start()
    {

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
            UIPopup_Booster.Show();
        });

        txtStar.text = HelperManager.DataPlayer.TotalStar.ToString();
        txtCoint.text = HelperManager.DataPlayer.TotalCoin.ToString();

        StartCoroutine(OnReciverItem());

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

    private void OnDestroy()
    {
        HelperManager.Save();
    }
}
