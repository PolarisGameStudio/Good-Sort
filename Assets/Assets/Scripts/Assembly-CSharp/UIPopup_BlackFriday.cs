using System.Collections.Generic;
using UnityEngine;

public class UIPopup_BlackFriday : MonoBehaviour
{
	public UITimerCountdownTMP timer;

	[Header("Reward")]
	public UIPopup_BlackFriday_Item[] items;

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
