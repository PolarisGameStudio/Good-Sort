using System;
using UnityEngine;

public class DateTimeController : MonoBehaviour
{
	public DateTime nextDay;

	public DateTime nextDayUTC;

	public static Action<DateTime> OnStartNewDay;

	public static Action<DateTime> OnStartNewDayUTC;

	private float _time;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void ResetTimeNewDay()
	{
	}

	private void ReseTargetUTCTime()
	{
	}

	private static DateTime GetTheNextDay()
	{
		return default(DateTime);
	}

	private static DateTime GetTheNextDayUTC()
	{
		return default(DateTime);
	}

	private void Update()
	{
	}
}
