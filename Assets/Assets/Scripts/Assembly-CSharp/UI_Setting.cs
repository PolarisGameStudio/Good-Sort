using Firebase.Analytics;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class UI_Setting : Dialog<UI_Setting>
{
	[Header("Music & Sound")]
	public Button btnSound;

	public Button btnHaptic;

	public Button btnMusic;

    public Button btnHome;

    public Button btnPause;

    public Sprite[] sprBtns;

    public Sprite[] sprSounds;

	public Sprite[] sprHaptics;

	public Sprite[] sprMusics;

    public Button btnClose;

    public GameObject objDisable;
    public RectTransform objReset;
    public TextMeshProUGUI txtSetting = null;


    public Action callbackShowSetting = null;

    private Image imgSound = null;
    private Image imgMusic = null;
    private Image imgVirabtion = null;

    private Image imgBGSound = null;
    private Image imgBGMusic = null;
    private Image imgBGVirabtion = null;


    private void Start()
    {
        imgSound = btnSound.GetComponent<Image>();
        imgMusic = btnMusic.GetComponent<Image>();
        imgVirabtion = btnHaptic.GetComponent<Image>();

        imgBGSound = btnSound.transform.parent.GetComponent<Image>();
        imgBGMusic = btnMusic.transform.parent.GetComponent<Image>();
        imgBGVirabtion = btnHaptic.transform.parent.GetComponent<Image>();


        UpdateUI_Setting();

        btnSound.onClick.AddListener(() => {
            Audio.soundEnabled = !Audio.soundEnabled;
            UpdateUI_Setting();
        });

        btnHaptic.onClick.AddListener(() => {
            HelperManager.DataPlayer.isVbration = !HelperManager.DataPlayer.isVbration;
            UpdateUI_Setting();
        });

        btnMusic.onClick.AddListener(() => {
            Audio.musicEnabled = !Audio.musicEnabled;
            if (Audio.musicEnabled)
            {
                Audio.ResumeBackgroundMusic();
            }
            else
            {
                Audio.PauseBackgroundMusic();
            }
            UpdateUI_Setting();
        });

        btnClose.onClick.AddListener(() => {
            btnClose.enabled = false;
            onClose();
        });

        btnHome.onClick.AddListener(() => {
            HelperManager.OnBackHomeScene();
        });

        btnHome.gameObject.SetActive(HelperManager.DataPlayer.LevelID > 0);

        btnPause.onClick.AddListener(() => { 
            AdsManager.Instance.ShowInterstitial((isShowAds) =>
            {
               /* var key_replay_level = "replay_" + HelperManager.DataPlayer.LevelID + 1;
                var value = PlayerPrefs.GetInt(key_replay_level, 0);
                Parameter[] lst = new Parameter[]
                  {
                        new Parameter("Level_id_restart", HelperManager.DataPlayer.LevelID + 1),
                        new Parameter("Level_id_numreplay", value)
                  };

                FirebaseLogHandle.LogEvent("Level_replay", lst);*/


                HelperManager.ShowGameScene();
            }, "Restart_Game");
        });
    }

    public void OnLoadScene()
    {
        HelperManager.OnLoadGameScene();
    }

    public void DisableSetting()
    {
        txtSetting.text = "Setting";
        objReset.anchoredPosition = Vector3.zero;
        objDisable.gameObject.SetActive(false);
    }

	private void OnEnable()
	{
		
    }

	private void OnDisable()
	{
	}

	private void UpdateUI_Setting()
	{
        imgSound.sprite = HelperManager.DataPlayer.isPlaySound ? sprSounds[0] : sprSounds[1];
        imgMusic.sprite = HelperManager.DataPlayer.isPlayMusic ? sprMusics[0] : sprMusics[1];
        imgVirabtion.sprite = HelperManager.DataPlayer.isVbration ? sprHaptics[0] : sprHaptics[1];

        imgBGSound.sprite = HelperManager.DataPlayer.isPlaySound ? sprBtns[0] : sprBtns[1];
        imgBGMusic.sprite = HelperManager.DataPlayer.isPlayMusic ? sprBtns[0] : sprBtns[1];
        imgBGVirabtion.sprite = HelperManager.DataPlayer.isVbration ? sprBtns[0] : sprBtns[1];
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
		callbackShowSetting?.Invoke();
        Hide();
    }
}
