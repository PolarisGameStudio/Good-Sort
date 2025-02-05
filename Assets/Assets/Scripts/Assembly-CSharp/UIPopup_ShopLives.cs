using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_ShopLives : MonoBehaviour
{
	public TextMeshProUGUI txtTitle;

	public UITimerCountdownTMP timerHearth;

	public RectTransform uiResource;

	public TextMeshProUGUI txtCurrentHearth;

	[Header("Full Vitality")]
	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	[Header("Watch Ads")]
	public RectTransform rectBtnWatchAds;

	public Button btnWatchAds;

	[Header("Free Live")]
	public RectTransform layoutButtonFreeLives;

	public RectTransform rectBtnFreeLiveV1;

	public Button btnFreeLiveV1;

	public RectTransform rectFreeLiveV1;

	public TextMeshProUGUI txtFreeLiveV1;

	public RectTransform rectBtnFreeLiveV2;

	public Button btnFreeLiveV2;

	public TextMeshProUGUI txtFreeLiveV2;

	public RectTransform rectBtnFreeLiveV2Disable;

	public Button btnFreeLiveV2Disable;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnFlyItemHearthComplete(ResourceType type, int value)
	{
	}

	private void OnReceiveMaxFreeLive()
	{
	}

	public void UpdateUI_Title(string strTitle)
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateUI_FreeLive(bool isActive)
	{
	}
}
