using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class MonoUtils
{

	public static T GetComponentOrAdd<T>(this GameObject @this) where T : Component
	{
		return null;
	}

	public static Coroutine Delay<T>(this T t, float timeSec, Action action, bool ignoreTimeScale = false) where T : MonoBehaviour
	{
		return null;
	}

	private static IEnumerator DelayCoroutine(float timeSec, Action action, bool ignoreTimeScale = false)
	{
		return null;
	}
}
