using System;
using Falcon.FalconCore.Scripts.Utils.FActions.Base;

namespace Falcon.FalconCore.Scripts.Utils.FActions.Variances.Starts
{
	public class UnitAction : StartAction, IStartAction, IContinuableAction, IFAction
	{
		private readonly Action action;

		private Exception exception;

		protected bool isDone;

		public override Exception Exception => null;

		public override bool Done => false;

		public UnitAction(Action action)
		{
		}

		public override void Invoke()
		{
		}
	}
	public class UnitAction<T> : UnitAction, IStartAction<T>, IContinuableAction<T>, IFAction<T>, IFAction, IContinuableAction, IStartAction
	{
		private readonly Func<T> action;

		public T Result { get; private set; }

		public UnitAction(Func<T> action)
			: base(null)
		{
		}

		public override void Invoke()
		{
		}

		public T InvokeAndGet()
		{
			return default(T);
		}
	}
}
