using System.Collections.Concurrent;

namespace Falcon.FalconCore.Scripts.Utils.Entities
{
	public class LockMap<T>
	{
		private readonly ConcurrentDictionary<T, LockKey<T>> dictionary;

		private bool lockAll;

		public bool TryLock(T key, out LockKey<T> lockKey)
		{
			lockKey = null;
			return false;
		}

		public LockKey<T> Lock(T key)
		{
			return null;
		}

		public LockAllKey<T> LockAll()
		{
			return null;
		}

		internal void Unlock(T key)
		{
		}

		internal void UnlockAll()
		{
		}
	}
}
