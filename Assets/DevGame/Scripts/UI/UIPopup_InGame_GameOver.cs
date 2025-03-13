using System;
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


    private void Start()
    {
        btnPlay.onClick.AddListener(() =>
        {
            onClose();
            LogicGame.Instance.OnSkillSwap(true);
        });

        btnWatchAds.onClick.AddListener(() =>
        {
            onClose();
            LogicGame.Instance.OnSkillSwap(true);
        });

        btnExit.onClick.AddListener(() =>
        {
            onClose();
            UIPopup_Booster.Show();
            UIPopup_Booster.Instance.isGameScene = true;
        });
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
