using UnityEngine;

namespace Falcon.FalconAnalytics.Scripts.Services
{
	public static class PlayTimeCheckService
	{
		private const string TotalTimeKey = "USER_TOTAL_TIME";

		private static long _lastPause;

		private static long? _sessionsSum;

		public static string SessionUid { get; }

		public static long SessionStartTime { get; private set; }

		public static long SessionsSum => 0L;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void Init()
		{
		}

		private static void SaveTotalTime()
		{
		}

		private static long CurrentSessionTime()
		{
			return 0L;
		}
	}
}
