using Falcon.FalconCore.Scripts.Services.GameObjs;
using Falcon.FalconCore.Scripts.Utils.Entities;
using UnityEngine;

namespace Falcon.FalconCore.Scripts.Services.MainThreads
{
	public class FThreadService : IPioneerService
	{
		internal static readonly FQueue<MainThreadAction> MainThreadActions;

		public static int? MainThreadId { get; private set; }

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		public static void Init()
		{
		}

		public void OnPreContinue()
		{
		}
	}
}
