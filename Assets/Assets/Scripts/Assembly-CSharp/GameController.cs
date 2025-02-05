using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Falcon;
using UnityEngine;

public class GameController : PersistentSingleton<GameController>
{
	private struct SessionScene
	{
		public int scene;

		public long session;
	}


	private static readonly List<string> _deviceTests;

	private static bool _isDeviceTest;

	public static Action<bool> onApplicationPause;

	public bool IsWinLevel;

	private readonly Dictionary<SceneState, string> _dicSceneName;

	private const string KEY_SESSION = "session";

	private DateTime _sessionDateTimeByScene;

	private static Coroutine _coroutineUpdateToServer;

	private static WaitForEndOfFrame wait;

	public static bool IsDeviceTest => false;

	protected override void Awake()
	{
	}

	private void GameStop(object sender, EventArgs e)
	{
	}

	private void Start()
	{
	}

	public void ChangeSceneState(SceneState sceneState)
	{
	}

	private void OnCompleteLevel()
	{
	}

	public double GetTimeInScene()
	{
		return 0.0;
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	public void LogSession(int sessionTime, SceneState sceneState)
	{
	}

	public static void UpdateDataToServer()
	{
	}

	private static IEnumerator DelayUpdateToServer()
	{
		return null;
	}

	public static void SendMessage(CSMessage message)
	{
	}

	public static bool CanSendMessage()
	{
		return false;
	}

	public static void SendMessage(CSMessageWaitLoginSuccess message)
	{
	}
}
