using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_BlackFriday_Item : MonoBehaviour
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

	public UIPopup_ListRewards_V2_Item collection;

	public TextMeshProUGUI txtCollection;

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
