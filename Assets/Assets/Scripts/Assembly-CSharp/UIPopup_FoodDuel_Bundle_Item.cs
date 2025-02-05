using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_FoodDuel_Bundle_Item : MonoBehaviour
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

	public RectTransform rectPowerUp;

	public PowerUp[] powerUps;

	public TextMeshProUGUI txtPie;

	public RectTransform rectSold;

	public RectTransform rectSale;

	public TextMeshProUGUI txtSale;

	public TextMeshProUGUI txtLimitBuy;

	[Header("Buy")]
	public RectTransform rectBtnBuy;

	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	public TextMeshProUGUI txtPriceOriginal;

	public void SetItemData(int itemIndex)
	{
	}
}
