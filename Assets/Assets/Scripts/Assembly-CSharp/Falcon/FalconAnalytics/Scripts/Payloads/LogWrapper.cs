using System;
using UnityEngine.Scripting;

namespace Falcon.FalconAnalytics.Scripts.Payloads
{
	[Serializable]
	public abstract class LogWrapper
	{
		public string data;

		public abstract string URL { get; }

		[Preserve]
		protected LogWrapper(string data)
		{
		}

		public void Send()
		{
		}

		protected virtual void TrySend()
		{
		}

		protected abstract void ValidateResponse(string response);
	}
}
