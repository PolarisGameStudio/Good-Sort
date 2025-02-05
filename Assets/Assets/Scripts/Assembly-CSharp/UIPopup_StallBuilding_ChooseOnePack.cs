using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_StallBuilding_ChooseOnePack : MonoBehaviour
{
	[Serializable]
	public class Pack
	{
		public TextMeshProUGUI txtGold;

		public RectTransform rectReward;

		public UIPopup_ListRewards_Item[] rewards;

		public Button btnRewardChest;

		public UIPanel_UnlockReward_Info panelRewardChest;

		public RectTransform rectEnvelope;

		public TextMeshProUGUI txtEnvelope;

		public RectTransform rectEnvelopeX2;

		public TextMeshProUGUI txtEnvelopeX2;

		public TextMeshProUGUI txtEnvelopeX2Original;

		public void SetItemData(List<ResourceValue> data)
		{
		}
	}

	public UITimerCountdownTMP timer;

	public Pack packBuy;

	public Pack packFree;

	public Button btnBuy;

	public TextMeshProUGUI txtPrice;

	public Button btnFree;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnBuyPack()
	{
	}

	private void UpdateUI()
	{
	}
}
