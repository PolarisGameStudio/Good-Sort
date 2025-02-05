using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_EndGame_Shop_GoldPack : MonoBehaviour
{
	public int goldPackType;

	public TextMeshProUGUI txtName;

	public RectTransform rectBanner;

	public Image normalOfferBg;

	public Image goldenOfferBg;

	[SerializeField]
	private Material normalTxtMaterial;

	[SerializeField]
	private Material goldenTxtMaterial;

	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnBuyComplete(int index, int gold)
	{
	}

	private void UpdateUI()
	{
	}

	public void TestUpdateUI(int goldpacktype)
	{
	}

	private string FormatNumberString(string numString)
	{
		return null;
	}
}
