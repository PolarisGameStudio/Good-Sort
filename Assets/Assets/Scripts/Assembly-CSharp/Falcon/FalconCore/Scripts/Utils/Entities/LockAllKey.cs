using System;

namespace Falcon.FalconCore.Scripts.Utils.Entities
{
	public class LockAllKey<T> : IDisposable
	{
		private readonly LockMap<T> lockMap;

		public LockAllKey(LockMap<T> lockMap)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
