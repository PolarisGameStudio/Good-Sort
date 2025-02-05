using System;
using Falcon.FalconCore.Scripts.Utils.FActions.Base;

namespace Falcon.FalconCore.Scripts.Controllers
{
	public class WaitInit : ChainAction
	{
		public WaitInit(IContinuableAction action)
			: base(null)
		{
		}

		public WaitInit(Action action)
			: base(null)
		{
		}

		public override bool CanInvoke()
		{
			return false;
		}
	}
	public class WaitInit<T> : WaitInit, IChainAction<T>, IContinuableAction<T>, IFAction<T>, IFAction, IContinuableAction, IChainAction, IFollowAction, IFollowAction<T>, IStartAction<T>, IStartAction
	{
		public T Result => default(T);

		public WaitInit(IContinuableAction<T> action)
			: base((IContinuableAction)null)
		{
		}

		public WaitInit(Func<T> action)
			: base((IContinuableAction)null)
		{
		}

		public bool TryInvoke(out T result)
		{
			result = default(T);
			return false;
		}

		public override bool CanInvoke()
		{
			return false;
		}

		public T InvokeAndGet()
		{
			return default(T);
		}
	}
}
