using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Sale_12_12_Item : MonoBehaviour
{
	[Serializable]
	public class PowerUp
	{
		public ResourceType kind;

		public RectTransform rectBox;

		public TextMeshProUGUI txtValue;
	}

	public Image rectBG;

	[Header("Reward")]
	public TextMeshProUGUI txtGold;

	public PowerUp[] powerUps;

	public PowerUp[] infiBoosters;

	public TextMeshProUGUI txtSale;

	[Header("Buy")]
	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	public TextMeshProUGUI txtPriceOriginal;

	public void SetItemData()
	{
	}
}
