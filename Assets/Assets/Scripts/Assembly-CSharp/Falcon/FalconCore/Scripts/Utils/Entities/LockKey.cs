using System;

namespace Falcon.FalconCore.Scripts.Utils.Entities
{
	public class LockKey<T> : IDisposable
	{
		private readonly LockMap<T> lockMap;

		private readonly T key;

		private readonly int threadId;

		private int codeDepth;

		internal LockKey(LockMap<T> lockMap, T key)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		internal bool TryLock()
		{
			return false;
		}
	}
}
