using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_EndGame_TimeUp : Dialog<UIPopup_EndGame_TimeUp>
{
	[Serializable]
	public class Popup
	{
		public FeatureType type;

		public UIPopup popup;
	}

	public UIPanel_EndGame_TimeUp_GetMore getmore;

	public Button btnExit;

	public Button btnBuyCoin;
	public Button btnWachAds;

	public UIPopup popupKeepChallenging;

	public Popup[] popups;

	private List<FeatureType> c_ListFeatureActive;

	private void OnEnable()
	{
		btnBuyCoin.onClick.RemoveAllListeners();
		btnWachAds.onClick.RemoveAllListeners();

        btnBuyCoin.onClick.AddListener(() => {
			NextStack();

        });

        btnExit.onClick.AddListener(() => {
            HelperManager.OnBackHomeScene();
        });

        btnWachAds.onClick.AddListener(() => {
            NextStack();
        });

    }

	public void NextStack()
	{
        LogicGame.Instance.OnBossterTimeUp();
        onClose();
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
