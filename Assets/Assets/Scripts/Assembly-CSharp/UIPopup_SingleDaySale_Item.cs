using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_SingleDaySale_Item : MonoBehaviour
{
	[Serializable]
	public class PowerUp
	{
		public ResourceType kind;

		public RectTransform rectBox;

		public TextMeshProUGUI txtValue;
	}

	[Serializable]
	public class Booster
	{
		public ResourceType kind;

		public RectTransform rectBox;
	}

	public Image rectBG;

	public Sprite sprRectBGDefault;

	public Sprite sprRectBGNoBooster;

	public RectTransform rectBooster;

	public TextMeshProUGUI txtTimeBooster;

	[Header("Reward")]
	public TextMeshProUGUI txtGold;

	public PowerUp[] powerUps;

	public Booster[] boosters;

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
