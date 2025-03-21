using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_InGame_GameOver : MonoBehaviour
{
	[Serializable]
	public class UIDifficultAsset
	{
		public Sprite bg;

		public Sprite texture;

		public Sprite area;

		public Sprite headline;

		public Sprite close;

		public TextMeshProUGUI textTitle;

		public Sprite bgBtn;
	}

	[Serializable]
	public class UIDifficult
	{
		public Image bg;

		public Image texture;

		public Image area;

		public Image headline;

		public Image close;

		public Image[] bgBtns;

		public TextMeshProUGUI txtHeadline;

		public void UpdateUI(UIDifficultAsset asset)
		{
		}
	}

	public GameObject[] tagDiffs;

	public UIDifficult uIDifficult;

	public UIDifficultAsset[] uiDifficults;

	public UIPopup_Booster_ButtonSelect[] boosters;

	public UIPopup_Booster_ButtonSelect_1[] boostersNew;

	public Sprite[] boosterLocks;

	public RectTransform rectBonusReward;

	public UITimerCountdownTMP txtTimerBonusReward;

	public Button btnHelpBonusReward;

	public RectTransform rectInfoBonusReward;

	public Image iconGoldenGiftBonusReward;

	public RectTransform bgPopup;

	public Button btnPlay;

	public Button btnWatchAds;

	public Button btnExit;

	private TextMeshProUGUI txtTitle;

	private void Awake()
	{
	}

	private void UpdateThemeDiff(int diff)
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateUI_TagX2Reward()
	{
	}
}
