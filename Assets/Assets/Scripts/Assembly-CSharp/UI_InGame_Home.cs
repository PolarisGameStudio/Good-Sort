using System;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_InGame_Home : MonoBehaviour
{
	[Serializable]
	public class Combo
	{
		public TextMeshProUGUI txtProgress;

		public Image imgProgress;

		public TextMeshProUGUI txtStar;

		public UIParticle fxStarClaim;

		public UIParticle fxProgress;

		public UI_InGame_Home_PoolFly_StarCombo poolStar;

		private int c_star;

		public void UpdateUI()
		{
		}
	}

	[Serializable]
	public class GoldenGift
	{
		public RectTransform rectBox;

		public RectTransform icon;

		public TextMeshProUGUI txtAmount;

		public UIParticle fxClaim;

		public UI_InGame_Home_PoolFly_GoldenGift poolGoldenGift;

		public UITutorialSystem tutorial;

		private bool isShowTutorial;

		public void UpdateUI()
		{
		}

		public void StartTutorial()
		{
		}
	}

	public GameObject[] uiPowerUps;

	public RectTransform rectAnchorTop;

	public RectTransform rectAnchorBottom;

	public static RectTransform s_worldPos_anchorTop;

	public static RectTransform s_worldPos_anchorBottom;

	public static RectTransform s_worldPos_progressCombo;

	public RectTransform[] uiGroups;

	public TextMeshProUGUI txtLevel;

	public Button btnPause;

	public Button btnRemoveAds;

	[Header("Infor")]
	public Combo uiCombo;

	public GoldenGift uiGoldenGift;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void OnGenLevelDone()
	{
	}

	private void UpdateUI_RemoveAds()
	{
	}

	private void UpdateUI_GoldenGift()
	{
	}

	private void UpdateUI_Booster()
	{
	}

	public void Back()
	{
	}
}
