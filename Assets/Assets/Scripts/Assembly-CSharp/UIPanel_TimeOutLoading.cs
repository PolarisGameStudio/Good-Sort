using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UIPanel_TimeOutLoading : MonoBehaviour
{

	public Action onRectNotifyClosed;

	public RectTransform rectLoading;

	public RectTransform rectNotify;

	private Coroutine _coroutineLoading;

	private WaitForSeconds waitForSeconds;

	private WaitForSeconds waitForSecondClose;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private IEnumerator CoroutineActiveLoading()
	{
		return null;
	}
}
