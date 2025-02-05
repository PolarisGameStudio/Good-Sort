using System;
using Falcon.FalconCore.Scripts.Utils.FActions.Base;

namespace Falcon.FalconCore.Scripts.Utils.FActions.Variances.Chains
{
	public class DelayAction : ChainAction
	{
		private readonly long createTime;

		private readonly TimeSpan delayTime;

		public DelayAction(IContinuableAction baseAction, TimeSpan delayTime)
			: base(null)
		{
		}

		public DelayAction(Action action, TimeSpan delayTime)
			: base(null)
		{
		}

		public override bool CanInvoke()
		{
			return false;
		}
	}
	public class DelayAction<T> : DelayAction, IChainAction<T>, IContinuableAction<T>, IFAction<T>, IFAction, IContinuableAction, IChainAction, IFollowAction, IFollowAction<T>
	{
		public T Result => default(T);

		public DelayAction(IContinuableAction<T> baseAction, TimeSpan delayTime)
			: base((IContinuableAction)null, default(TimeSpan))
		{
		}

		public DelayAction(Func<T> action, TimeSpan delayTime)
			: base((IContinuableAction)null, default(TimeSpan))
		{
		}

		public bool TryInvoke(out T result)
		{
			result = default(T);
			return false;
		}
	}
}
