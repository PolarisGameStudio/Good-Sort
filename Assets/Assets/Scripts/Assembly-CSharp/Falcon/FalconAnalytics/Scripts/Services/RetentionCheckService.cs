using System;
using UnityEngine;

namespace Falcon.FalconAnalytics.Scripts.Services
{
	public static class RetentionCheckService
	{
		private const string LatestLoginDateKey = "LATEST_DATE";

		public static int ActiveDays
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int Retention => 0;

		public static bool RetentionChanged => false;

		public static DateTime FirstLoginDate => default(DateTime);

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void Init()
		{
		}

		public static void Refresh()
		{
		}
	}
}
