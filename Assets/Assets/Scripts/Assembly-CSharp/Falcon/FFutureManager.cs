using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Falcon
{
	public sealed class FFutureManager
	{
	
		private static readonly FFutureManager instance;

		private ConcurrentDictionary<string, FFuture> messageId2Future;

		private ConcurrentDictionary<int, HashSet<FFuture>> timeout2Futures;

		private Thread t;

		public static FFutureManager Instance => null;

		static FFutureManager()
		{
		}

		private FFutureManager()
		{
		}

		private void Start()
		{
		}

		private IEnumerator Run()
		{
			return null;
		}

		public void Put(string messageId, FFuture future)
		{
		}

		public void OnResponse(CSSCResponse message)
		{
		}
	}
}
