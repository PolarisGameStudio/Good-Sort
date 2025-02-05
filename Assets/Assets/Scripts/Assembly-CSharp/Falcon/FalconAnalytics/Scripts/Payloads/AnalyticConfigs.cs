using UnityEngine;

namespace Falcon.FalconAnalytics.Scripts.Payloads
{
	public static class AnalyticConfigs
	{
		public static AnalyticConfig Instance { get; private set; }

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AssignEvent()
		{
		}
	}
}
