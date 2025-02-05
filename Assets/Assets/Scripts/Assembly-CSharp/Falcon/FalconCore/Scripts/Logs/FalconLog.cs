using System.Diagnostics;
using Falcon.FalconCore.Scripts.Utils.Singletons;

namespace Falcon.FalconCore.Scripts.Logs
{
	public abstract class FalconLog<T> : FSingleton<T> where T : FalconLog<T>, new()
	{
		[Conditional("ENABLE_LOG")]
		public void Info(object info)
		{
		}

		[Conditional("ENABLE_LOG")]
		public void Warning(object info)
		{
		}

		[Conditional("ENABLE_LOG")]
		public void Error(object exception)
		{
		}

		protected abstract string GetColor();
	}
}
