using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_MasterPass_BuyPremium : MonoBehaviour
{
	public UITimerCountdownTMP timer;

	public RawImage avatar;

	public Text txtNamePremium;

	public TextMeshProUGUI txtMaxLive;

	public TextMeshProUGUI txtDesMaxLive;

	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	public UIPopup popupBuyPremiumCompleted;

	private Action OnCallbackBuySuccess;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnBuyPremium()
	{
	}

	public void UpdateUI(Action onCallbackBuySuccess)
	{
	}
}
