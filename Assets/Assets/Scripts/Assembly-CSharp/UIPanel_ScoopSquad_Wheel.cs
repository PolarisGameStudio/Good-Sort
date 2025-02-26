using System;
using Coffee.UIExtensions;
using Spine.Unity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_ScoopSquad_Wheel : MonoBehaviour
{
	[Serializable]
	public class Showcase
	{
		public RectTransform rectBox;

		public SkeletonGraphic ske;

		public BoneFollowerGraphic[] followSkes;

		public TextMeshProUGUI txtRewardSpinS;

		public RectTransform[] rectRewardTypes;

		public UIParticle[] fxReward;

		public UIParticle[] fxImpact;

		public void OpenUI(int indexReward, (int score, StarCollabLuckyWheelExtraRewardType extraType) dataReward, Action onComplete)
		{
		}

		public void CloseUI()
		{
		}
	}

	public static Action<int, int> OnSpinWheel;

	public TextMeshProUGUI[] txtRewardWheels;

	public TextMeshProUGUI txtCurrentMilk;

	public Button btnSpin;

	public TextMeshProUGUI txtPriceMilkSpin;

	public Button btnPrev;

	public Button btnNext;

	public RectTransform rectLoading;

	public RectTransform rectLockUI;

	[Header("Showcase")]
	public Showcase showcase;

	public RectTransform rectCreamFlyItem;

	public Image iconCreamFlyItem;

	public Sprite[] sprIconFlyItems;

	public TextMeshProUGUI txtValueCreamFlyItem;

	public UIParticle fxCreamFlyItem;

	[Header("Milk Fly")]
	public SkeletonGraphic rectSkeBoxMilkFly;

	public RectTransform rectMilkFlyItem;

	public TextMeshProUGUI txtValueMilkFlyItem;

	public UIParticle fxMilkFlyItem;

	public UIParticle fxRewardTrail;

	public UIPanel_ScoopSquad_HomeUserScoreForSlotTarget_Item target;

	[Header("Wheel")]
	public RectTransform wheel;

	public float spinDuration;

	public int minSpins;

	public AnimationCurve curve;

	public UIParticle fxWheelPlay;

	private bool c_IsSpinning;

	private int c_LastMilk;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSpin(int indexSlot, int indexReward)
	{
	}

	private void SpawnFlyItem((int score, StarCollabLuckyWheelExtraRewardType extraType) data, Action OnReceiveCreamComplete)
	{
	}

	public void UpdateUI(int indexSlot)
	{
	}
}
