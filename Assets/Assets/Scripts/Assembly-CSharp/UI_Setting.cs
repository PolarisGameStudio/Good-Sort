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

    private void Start()
	{
	}

	private void OnEnable()
	{
		btnSound.onClick.RemoveAllListeners();
		btnHaptic.onClick.RemoveAllListeners();
		btnMusic.onClick.RemoveAllListeners();
        btnClose.onClick.RemoveAllListeners();

		btnSound.onClick.AddListener(() => { 

		});

        btnHaptic.onClick.AddListener(() => { 

		});

        btnMusic.onClick.AddListener(() => { 

		});

        btnClose.onClick.AddListener(() => {
			btnClose.enabled = false;
            onClose();
        });
    }

	private void OnDisable()
	{
	}

	private void UpdateUI_Setting()
	{
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
