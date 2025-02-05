using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Setting : MonoBehaviour
{
	[Serializable]
	public class ThemeAndLanguage
	{
		public GameObject btnLanguageFull;

		public GameObject btnLanguageShort;

		public GameObject btnThemeContainer;

		public Button btnTheme;

		public Sprite[] themeOnOff;

		public TextMeshProUGUI txtOnOff;

		public Image imgOnOff;
	}

	[Serializable]
	public class VisisFanpage
	{
		public Button btnFanpage;

		public GameObject noti;

		public TextMeshProUGUI txtGold;

		public void UpdateUI()
		{
		}
	}

	[Header("Music & Sound")]
	public Button btnSound;

	public Button btnHaptic;

	public Button btnMusic;

	public Sprite[] sprSounds;

	public Sprite[] sprHaptics;

	public Sprite[] sprMusics;

	[Header("Language")]
	public Button[] btnLanguages;

	public TextMeshProUGUI[] txtLanguages;

	public UIPopup popupLanguage;

	[Header("Save Progress")]
	public Button btnSaveProgress;

	[Header("Extend")]
	public Button btnCustomCare;

	public Button btnTermAndPolicy;

	public TextMeshProUGUI txtVersion;

	public ThemeAndLanguage themeAndLanguage;

	public VisisFanpage visisFanpage;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateUI_Setting()
	{
	}
}
