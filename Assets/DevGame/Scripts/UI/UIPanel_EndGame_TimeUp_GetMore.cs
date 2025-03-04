using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_EndGame_TimeUp_GetMore : MonoBehaviour
{
	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	public Button btnWatchAd;

	public TextMeshProUGUI txtTime;

	[Header("Fail Safe")]
	private int _extraGoldForPrice;

	private int _extraTimeByGold;

	private int _extraTimeByAds;

	[SerializeField]
	private TextMeshProUGUI _txtTimeBonusByGold;

	[SerializeField]
	private TextMeshProUGUI _txtTimeBonusByAds;

	[SerializeField]
	private GameObject _bonusByGoldContainer;

	[SerializeField]
	private GameObject _bonusByAdsContainer;

	private void OnEnable()
	{
	}

	public void UpdateUI(Action onBuyItem)
	{
	}

	private void UpdateFailSafe()
	{
	}

	private int GetTimeForRemainingProgress()
	{
		return 0;
	}

	private void TurnOffButtonWatchAds()
	{
	}
}
