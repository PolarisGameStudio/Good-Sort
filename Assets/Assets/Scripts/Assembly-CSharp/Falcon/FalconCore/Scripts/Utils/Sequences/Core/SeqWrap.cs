using System;
using System.Collections.Generic;

namespace Falcon.FalconCore.Scripts.Utils.Sequences.Core
{
	public class SeqWrap<T> : Sequence<T> where T : class
	{
		private readonly Action<Exception> ifDropOut;

		private readonly IEnumerator<T> enumerator;

		public SeqWrap(IEnumerator<T> enumerator, Action<Exception> ifDropOut = null)
		{
		}

		protected override IEnumerator<T> EnumeratorT()
		{
			return null;
		}

		protected override void OnException(Exception e)
		{
		}
	}
}
