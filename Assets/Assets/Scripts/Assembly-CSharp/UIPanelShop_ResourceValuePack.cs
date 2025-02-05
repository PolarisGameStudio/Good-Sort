using System;
using System.Collections.Generic;
using Beardy;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelShop_ResourceValuePack : MonoBehaviour
{
	[Serializable]
	public class Reward
	{
		public RectTransform rectBox;

		public Image icon;

		public TextMeshProUGUI txtAmount;
	}

	[Header("Reward")]
	public TextMeshProUGUI txtGold;

	public Beardy.GridLayoutGroup layoutPowerUps;

	public Reward[] rewardPowerUps;

	public Beardy.GridLayoutGroup layoutBoosters;

	public Reward[] rewardBoosters;

	public Reward rewardInfiHearth;

	public void UpdateUI(List<ResourceValue> dataReward)
	{
	}
}
