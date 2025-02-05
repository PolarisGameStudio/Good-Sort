using System;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_InGame_RateUs : MonoBehaviour
{
	public Button btnRate;

	private Action onDisable;

	private void OnDisable()
	{
	}

	public void UpdateUI(Action onCloseThisPopup)
	{
	}
}
