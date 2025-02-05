using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel_EndGame_Shop_BundlePack : MonoBehaviour
{
	public BundleType bundleType;

	public TextMeshProUGUI txtName;

	public RectTransform rectBanner;

	public UIPanelShop_ResourceValuePack panelValuePack;

	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	public RectTransform tagMostPopular;

	public RectTransform tagBestValue;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnBuyComplete(BundleType type)
	{
	}

	private void UpdateUI()
	{
	}
}
