using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Setting : Dialog<UI_Setting>
{
	[Header("Music & Sound")]
	public Button btnSound;

	public Button btnHaptic;

	public Button btnMusic;

	public Sprite[] sprSounds;

	public Sprite[] sprHaptics;

	public Sprite[] sprMusics;

    public Button btnClose;

	public Action callbackShowSetting = null;

    private Image imgSound = null;
    private Image imgMusic = null;
    private Image imgVirabtion = null;


    private void Start()
	{
        imgSound = btnSound.GetComponent<Image>();
        imgMusic = btnMusic.GetComponent<Image>();
        imgVirabtion = btnHaptic.GetComponent<Image>();


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
