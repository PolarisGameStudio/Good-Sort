using System.Diagnostics;
using UnityEngine;

public static class LogUtils
{
	[Conditional("ENABLE_LOG")]
	public static void LogError(object message)
	{
	}

	[Conditional("ENABLE_LOG")]
	public static void LogError(object message, Object context)
	{
	}

	[Conditional("ENABLE_LOG")]
	public static void LogWarning(object message)
	{
	}

	[Conditional("ENABLE_LOG")]
	public static void LogWarning(object message, Object context)
	{
	}

	[Conditional("ENABLE_LOG")]
	public static void Log(object message)
	{
	}

	[Conditional("ENABLE_LOG")]
	public static void Log(object message, Object context)
	{
	}
}
