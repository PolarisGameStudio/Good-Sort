using System.Collections.Generic;
using Spine.Unity;
using SuperScrollView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UICollection : MonoBehaviour
{
	public static RectTransform s_RectBtnHelp;

	public static LoopGridView s_GridViewSet;

	public RectTransform rectLevelToUnlock;

	public RectTransform rectFeatureComing;

	public RectTransform rectFeature;

	public Button btnHelp;

	public UIPopup popupHelp;

	public TextMeshProUGUI txtTitle;

	public UITimerCountdownTMP timer;

	public SkeletonGraphic skeBanner;

	[Header("Reward")]
	public TextMeshProUGUI txtRewardGold;

	public TextMeshProUGUI txtRewardBooster;

	public Button btnInfoRewardBadge;

	public UIRect_Profile_Badge rewardBadge;

	public UIPopup popupRewardBadge;

	[Header("Progress")]
	public Slider progress;

	public TextMeshProUGUI txtProgress;

	public Button btnInfoCardProgress;

	public Button btnInfoChestProgress;

	public UIPanel_Collection_InfoText uiPanelInfoText;

	public UIPanel_Collection_InfoRewardChest uiPanelInfoRewardChest;

	[Header("List Set")]
	public ScrollRect scrollRect;

	public LoopGridView gridScrollView;

	public RectTransform rectLoading;

	[Header("Recycle")]
	public Button btnOpenCardStar;

	public RectTransform rectCanBuyCardStar;

	public UIPopup popupCardStar;

	private List<CardSet> c_data;

	private bool initGridView;

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

	private void OnLocalize()
	{
	}

	private void OnGetCardComplete()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateUI_Scroll()
	{
	}

	private LoopGridViewItem InitGridView(LoopGridView view, int itemIndex, int arg3, int arg4)
	{
		return null;
	}
}
