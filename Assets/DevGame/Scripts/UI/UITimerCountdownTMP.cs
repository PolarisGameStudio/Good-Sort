using System;
using TMPro;
using UnityEngine;

public class UITimerCountdownTMP : MonoBehaviour
{
	private TextMeshProUGUI timeText;

	public Action onStartTimer;

	public Action onStopTimer;

	private bool timerIsRunning;

	private double timeRemaining;

	private long timeRemainingLong;

	private string formatTimer;

	private float _currentTimeInterval;

	private DateTime _targetTime;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public TextMeshProUGUI GetTimeTextTMP()
	{
		return null;
	}

	public string GetFormatTimeDefault()
	{
		return null;
	}

	public void StartTimer(TimeSpan timeSpan, string format = "{0}{1}{2}{3}")
	{
	}

	public void Stop()
	{
	}

	private void UpdateTime()
	{
	}

	private void DisplayTime(double timeToDisplay)
	{
	}
}
