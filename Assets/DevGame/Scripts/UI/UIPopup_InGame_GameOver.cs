using System;
using System.Security.AccessControl;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_InGame_GameOver : Dialog<UIPopup_InGame_GameOver>
{
	public RectTransform rectBonusReward;

	public RectTransform bgPopup;

	public Button btnPlay;

	public Button btnWatchAds;

	public Button btnExit;
    public ShowToas showToas;
    int price = 400;


    private void Start()
    {
        btnPlay.onClick.AddListener(() =>
        {
            if (!OnPrice())
            {
                return;
            }
            onClose();
            LogicGame.Instance.OnSkillSwap(true);
        });

        btnWatchAds.onClick.AddListener(() =>
        {
            AdsManager.Instance.ShowRewardBasedVideo((success) =>
            {
                if (success)
                {
                    onClose();
                    LogicGame.Instance.OnSkillSwap(true);
                }
            }, "OnGameOver_Skill_Replay");

        });

        btnExit.onClick.AddListener(() =>
        {
            onClose();
            UIPopup_Booster.Show();
            UIPopup_Booster.Instance.isGameScene = true;
        });
    }

    public bool OnPrice()
    {
        if (HelperManager.DataPlayer.TotalCoin < price)
        {
            showToas.RunActionToas();
            return false;
        }
        HelperManager.OnAddTotalCoin(-price);
        return true;
    }

    public static void Show()
    {
        Open();
    }
    public static void Hide()
    {
        Close();
    }

    public void onClose()
    {
        Hide();
    }

}
