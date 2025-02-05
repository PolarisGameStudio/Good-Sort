using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Falcon;

public class NetMonobehavior : PersistentSingleton<NetMonobehavior>
{


	public static FSocketIOChannel channel;

	public static FSession session;

	public static bool sessionActive;

	public static bool fisrtLogin;

	public static bool firstOpen;

	private const string KEY_SERVER = "key_server_info";

	public static Action<bool> onUpdateSessionState;

	private TimeSpan timePauseSpan;

	public static float timePause;

	public static bool appIsPause;

	public static bool isLoading;

	public static bool reconnecting;

	public bool first;

	public bool ActiveSession
	{
		set
		{
		}
	}

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private IEnumerator DelayConnect()
	{
		return null;
	}

	public bool ConnectedToServer()
	{
		return false;
	}

	public void InitUDP()
	{
	}

	private IEnumerator DelayInitUDP()
	{
		return null;
	}

	private void OnApplicationPause(bool pause)
	{
	}

	public void ReConect()
	{
	}

	private IEnumerator ReConectToServer()
	{
		return null;
	}

	public IEnumerator ReForcusApp(float t)
	{
		return null;
	}

	public void DisconnectServer()
	{
	}

	private string DataDefault()
	{
		return null;
	}

	public void OnChangeServer(ScChangeServer sc)
	{
	}
}
