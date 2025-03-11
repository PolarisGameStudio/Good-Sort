using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIResource : MonoBehaviour
{
	[Header("Amount")]
	public TextMeshProUGUI txtHearth;

	public TextMeshProUGUI txtGold;

	public TextMeshProUGUI txtStar;

	[Header("Get More")]
	public Button btnGetMoreHearth;

	public Button btnGetMoreGold;

	[Header("Infinite & Timer")]
	public RectTransform rectHearthInfinite;

	public RectTransform rectIconHearthPlus;

	public UITimerCountdownTMP timerHearth;

	[Header("Target Fly Item")]
	public RectTransform iconTargetHearth;

	public RectTransform iconTargetGold;

	public RectTransform iconTargetStar;

	[Header("Tween & Fx")]
	public bool canRunTween;

	public DOTweenAnimation tweenHearth;

	public DOTweenAnimation tweenGold;

	public DOTweenAnimation tweenStar;

	public ParticleSystem fxHearth;

	public ParticleSystem fxGold;

	public ParticleSystem fxStar;

	private void Start()
	{
		txtGold.text = HelperManager.DataPlayer.TotalCoin.ToString();
        txtStar.text = HelperManager.DataPlayer.TotalStar.ToString();


    }

    private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateUI_Hearth()
	{
	}

	private void UpdateUI_GoldAndStar()
	{
	}

	private void OnPoolFlyUpdate(ResourceType type, bool isPlayFx)
	{
	}
}
