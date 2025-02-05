using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIShop_Gold_WatchAds_Item : MonoBehaviour
{
	public Image bg;

	public Sprite[] sprBGs;

	public RectTransform rectActiveAds;

	public RectTransform rectActiveFree;

	public RectTransform rectDeactiveAds;

	public TextMeshProUGUI txtValue;

	public Button btnWatchAds;

	public UITimerCountdownTMP txtCountDown;

	public bool isUsingOverlayFlyResource;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnWatchAdsGold(int gold)
	{
	}

	private void UpdateUI()
	{
	}
}
