using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class TimeCheatPrevention : MonoBehaviour
{

	[Header("Debug")]
	public bool m_DebugOutput;

	[Header("Callback")]
	[Range(1f, 10f)]
	[Tooltip("When it is impossible to get a time estimate or a server time, the plugin will retry getting a Internet based time this many seconds before triggering the callback with the device time instead.")]
	public float m_CallbackTimeout;

	public static UnityEvent OnCheatFreeTimeAvailable;

	[Tooltip("Callback that triggers as soon as there is either a server-based time, or a cheat-free estimate. If neither is available, the callback will trigger after a time threshold with regardless. This ensures that the callback will be called regardless")]
	public UnityEvent m_OnCheatFreeTimeAvailable;

	private bool m_CallbackNeedsTriggering;

	private float m_CallbackTriggerTimeOut;

	protected static TimeCheatPrevention _instance;

	private DateTime m_ServerTimeStampUTC;

	private float m_ServerTimeLastUpdated;

	private float m_ServerTimeRetryTimer;

	private float m_ServerTimeRetryTimerNext;

	private bool m_ServerTimeRequestRunning;

	private DateTime m_LastConfirmedTimeStampUTC;

	private float m_DeviceUpTimeDelta;

	private bool m_UpdateEstimationTimestampWithServerTimestamp;

	private bool m_UsingDeviceTime;

	private bool m_SkipFrame;

	private static List<string> sBackupServers;

	private Coroutine m_CoroutineHandle;

	private Thread m_Thread;

	private static bool sUseThreads;

	private static TimeCheatPrevention Instance => null;

	private void Awake()
	{
	}

	private void InitializeTimeCheatPrevention()
	{
	}

	private void Start()
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	private void RefreshCheatFreeTime()
	{
	}

	private void UpdateEstimatedTime()
	{
	}

	private void UpdateEstimationTimeStamp(DateTime dt)
	{
	}

	private static long GetElapsedTimeSinceLastBoot()
	{
		return 0L;
	}

	private void UpdateServerTime()
	{
	}

	private void GetServerTime_Thread(object obj)
	{
	}

	private IEnumerator GetServerTime()
	{
		return null;
	}

	private bool TryGetServerTimeFromIP(IPAddress targetAddress)
	{
		return false;
	}

	private void Update()
	{
	}

	private void TriggerOnCheatFreeTimeAvailableCallback()
	{
	}

	private static void Log(string message)
	{
	}

	public static DateTime GetDateTimeUTC()
	{
		return default(DateTime);
	}

	public static bool HasServerTime()
	{
		return false;
	}

	public static bool IsUsingLocalDeviceTime()
	{
		return false;
	}

	public static bool IsUsingEstimatedTime()
	{
		return false;
	}

	public static bool IsPlatformTimeEstimationSupported()
	{
		return false;
	}

	public static string GetTimeStamp()
	{
		return null;
	}

	public static DateTime ParseTimeStamp(ref string timeStamp)
	{
		return default(DateTime);
	}

	public static double GetSecondsSinceTimeStamp(ref string timeStamp, int capToMaxTime = -1)
	{
		return 0.0;
	}
}
