using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Falcon.FalconCore.Scripts.Utils.Entities
{
	public class FQueue<T> : ConcurrentQueue<T>
	{
		public List<T> Clear()
		{
			return null;
		}

		public void EnqueueAll(IEnumerable<T> collection)
		{
		}

		public void Remove(T item)
		{
		}
	}
}
