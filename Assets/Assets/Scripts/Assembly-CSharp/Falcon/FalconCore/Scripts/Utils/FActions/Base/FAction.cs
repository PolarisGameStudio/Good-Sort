using System;
using Falcon.FalconCore.Scripts.Utils.Entities;
using UnityEngine;

namespace Falcon.FalconCore.Scripts.Utils.FActions.Base
{
	public abstract class FAction : IFAction
	{
		private static readonly FQueue<FAction> ActionQueue;

		public abstract Exception Exception { get; }

		public abstract bool Done { get; }

		public virtual void Schedule()
		{
		}

		public virtual void Cancel()
		{
		}

		public abstract void Invoke();

		public abstract bool CanInvoke();

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		public static void InitFAction()
		{
		}
	}
}
