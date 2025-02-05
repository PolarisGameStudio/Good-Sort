using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Falcon.FalconCore.Scripts.Utils.Entities;
using JetBrains.Annotations;

namespace Falcon.FalconCore.Scripts.Entities
{
	public class FConcurrentDictionary<T, V> : ConcurrentDictionary<T, V>
	{
		private readonly LockMap<T> lockMap;

		public object this[object key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public new V this[T key]
		{
			get
			{
				return default(V);
			}
			set
			{
			}
		}

		public FConcurrentDictionary()
		{
		}

		public FConcurrentDictionary([NotNull] IEnumerable<KeyValuePair<T, V>> collection)
		{
		}

		public FConcurrentDictionary([NotNull] IEnumerable<KeyValuePair<T, V>> collection, [NotNull] IEqualityComparer<T> comparer)
		{
		}

		public FConcurrentDictionary([NotNull] IEqualityComparer<T> comparer)
		{
		}

		public FConcurrentDictionary(int concurrencyLevel, [NotNull] IEnumerable<KeyValuePair<T, V>> collection, [NotNull] IEqualityComparer<T> comparer)
		{
		}

		public FConcurrentDictionary(int concurrencyLevel, int capacity)
		{
		}

		public FConcurrentDictionary(int concurrencyLevel, int capacity, [NotNull] IEqualityComparer<T> comparer)
		{
		}

		public V Compute(T key, Func<bool, V, V> function)
		{
			return default(V);
		}

		public KeyValuePair<bool, V> ComputeIfPresent(T key, Func<V, V> ifPresent)
		{
			return default(KeyValuePair<bool, V>);
		}

		public bool ComputeIfPresent(T key, Action<V> ifPresent)
		{
			return false;
		}

		public KeyValuePair<bool, V> ComputeIfAbsent(T key, Func<V> ifAbsent)
		{
			return default(KeyValuePair<bool, V>);
		}

		public bool ComputeIfAbsent(T key, Action ifAbsent)
		{
			return false;
		}

		public V GetOrSet(T key, V orSet)
		{
			return default(V);
		}

		public V GetOrDefault(T key, V orDefault)
		{
			return default(V);
		}

		public bool Replace(T key, V ifAbsent)
		{
			return false;
		}

		public new void Clear()
		{
		}

		public bool Contains(KeyValuePair<T, V> item)
		{
			return false;
		}

		public void Add(T key, V value)
		{
		}

		public bool Remove(T key)
		{
			return false;
		}
	}
}
