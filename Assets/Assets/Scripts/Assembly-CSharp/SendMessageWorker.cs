using System.Collections.Generic;
using UnityEngine;

public class SendMessageWorker : Singleton<SendMessageWorker>
{
	public Queue<CSMessageWaitLoginSuccess> queue;

	private Coroutine _coroutine;

	public bool IsEmpty => false;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnChangeScene(SceneState state)
	{
	}

	private void OnLogin(bool obj)
	{
	}

	public void AddQueue(CSMessageWaitLoginSuccess cSMessage)
	{
	}
}
