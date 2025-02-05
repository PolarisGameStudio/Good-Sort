using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Falcon.FalconCore.Scripts.Utils.Sequences.Core
{
	public abstract class Sequence<T> : Sequence, IEnumerator<T>, IEnumerator, IDisposable where T : class
	{
		public new T Current => null;

		private void CheckException()
		{
		}

		protected sealed override IEnumerator Enumerator()
		{
			return null;
		}

		protected abstract IEnumerator<T> EnumeratorT();

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
	public abstract class Sequence : ISequence, IEnumerator
	{
		private Stack<IEnumerator> enumerators;

		private readonly Guid guid;

		private Stack<IEnumerator> Enumerators => null;

		public object Current { get; private set; }

		public Exception Exception { get; private set; }

		public bool Failed => false;

		public bool Done => false;

		protected abstract IEnumerator Enumerator();

		public virtual bool MoveNext()
		{
			return false;
		}

		private void CheckCurrent(object current)
		{
		}

		public void Reset()
		{
		}

		public void Cancel()
		{
		}

		protected virtual void OnException(Exception e)
		{
		}

		public bool TryContinue()
		{
			return false;
		}

		public IEnumerator Wait()
		{
			return null;
		}

		private bool Equals(Sequence other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
