using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Booster_GetMore : MonoBehaviour
{
	public Image icon;

	public TextMeshProUGUI txtDes;

	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	public Button btnWatchAd;

	public void UpdateUI(BoosterKind kind, Action onBuySuccess)
	{
	}
}
