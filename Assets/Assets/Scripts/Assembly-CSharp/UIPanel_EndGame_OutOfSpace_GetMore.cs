using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_EndGame_OutOfSpace_GetMore : MonoBehaviour
{
	[SerializeField]
	private Image _icon;

	[SerializeField]
	private TextMeshProUGUI _testDes;

	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	public Button btnWatchAd;

	private PowerupKind _powerupKind;

	[Header("Fail Safe")]
	private int _extraGoldForPrice;

	[SerializeField]
	private Image _iconPowerupByGold;

	[SerializeField]
	private Image _iconPowerupByAds;

	[SerializeField]
	private GameObject _powerupByGoldContainer;

	[SerializeField]
	private GameObject _powerupByAdsContainer;

	[SerializeField]
	private GameObject _2PowerupByGoldContainer;

	private List<PowerupKind> _powerupKindBonusByGold;

	private List<PowerupKind> _powerupKindBonusByAds;

	public void UpdateUI(Action onBuyItem)
	{
	}

	private void UpdateFailSafe()
	{
	}

	private void TurnOffButtonWatchAds()
	{
	}
}
