using System;
using UnityEngine;

public class UnityGameServicesInit : MonoBehaviour
{
	private const string k_Environment = "production";

	private bool _isInit;

	public Action onInitSuccess;

	public bool IsInit => false;

	private void Awake()
	{
	}

	private void Initialize(Action onSuccess, Action<string> onError)
	{
	}

	private void OnSuccess()
	{
	}

	private void OnError(string message)
	{
	}
}
