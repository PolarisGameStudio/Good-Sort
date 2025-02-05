using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_Digging_ChooseOne : MonoBehaviour
{
	public UIPopup_Digging_ChooseOne_Item[] items;

	public Button btnChestPack_1;

	public Button btnChestPack_2;

	public UIPanel_UnlockReward_Info panelInfoChestPack_1;

	public UIPanel_UnlockReward_Info panelInfoChestPack_2;

	[Header("Buy All")]
	public RectTransform rectBuyAll;

	public Button btnBuyAll;

	public TextMeshProUGUI txtPriceBuyAll;

	public TextMeshProUGUI txtPriceBuyAllOriginal;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnBuyPack(List<ResourceValue> dataReward)
	{
	}

	private void UpdateUI()
	{
	}
}
