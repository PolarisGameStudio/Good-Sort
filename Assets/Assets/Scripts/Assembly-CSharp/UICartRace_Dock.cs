using System;
using UnityEngine;
using UnityEngine.UI;

public class UICartRace_Dock : MonoBehaviour
{
	public static Action OnCloseUI;

	public RectTransform rectRegister;

	public Button btnRegister;

	public RectTransform rectPlayingOrEnd;

	public UITimerCountdownTMP timerPlayingOrEnd;

	public UICartRace_Dock_Item[] items;

	public RectTransform rectEndRace;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateUI()
	{
	}
}
