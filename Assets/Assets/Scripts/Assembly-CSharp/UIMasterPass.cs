using System;
using System.Collections.Generic;
using Coffee.UIExtensions;
using SuperScrollView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMasterPass : MonoBehaviour
{
	[Serializable]
	public class Data
	{
		public int itemIndex;

		public (ChestType?, List<ResourceValue>) dataFree;

		public (ChestType?, List<ResourceValue>) dataGold;
	}

	public static bool s_IsTweenProgressChange;

	public static LoopGridView s_ScrollView;

	public static UIPopup s_PopupPremium;

	public static RectTransform s_RectTransform;

	public static Sprite[] s_SprIconChests;

	public Button[] btnHelps;

	public UIPopup popupHelp;

	public UITimerCountdownTMP timer;

	public RectTransform rectProgress;

	public Image imgProgress;

	public TextMeshProUGUI txtProgress;

	public TextMeshProUGUI txtCurrentLevel;

	public UIParticle fxLevel;

	public ScrollRect scrollRect;

	public UIScrollRectSnapToChild scrollRectSnap;

	public LoopGridView scrollView;

	public RectTransform rectLock;

	public UIMasterPass_BubbleInforItem_Manager bubbleInfoClaimItem;

	public UITutorialSystem tutorial;

	[Header("Premium")]
	public RectTransform rectPremium;

	public Button btnActivate;

	public RectTransform rectPremiumActivated;

	public UIPopup popupBuyPremium;

	[Header("Sprite Chest")]
	public Sprite[] sprIconChests;

	private bool initLoopGridView;

	private List<Data> data;

	private void Awake()
	{
	}

	private void OnDestroy()
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

	public void UpdateUI_TweenScrollDisableLockPremium()
	{
	}

	private UIMasterPass_Item GetItem(int index)
	{
		return null;
	}

	private LoopGridViewItem InitGridView(LoopGridView view, int itemIndex, int row, int column)
	{
		return null;
	}
}
