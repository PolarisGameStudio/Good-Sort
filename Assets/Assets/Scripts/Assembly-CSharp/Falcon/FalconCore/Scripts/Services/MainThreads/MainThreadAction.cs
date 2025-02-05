using System;
using Falcon.FalconCore.Scripts.Utils.FActions.Base;

namespace Falcon.FalconCore.Scripts.Services.MainThreads
{
	public class MainThreadAction : ChainAction
	{
		public MainThreadAction(IContinuableAction baseAction)
			: base(null)
		{
		}

		public MainThreadAction(Action baseAction)
			: base(null)
		{
		}

		public override void Invoke()
		{
		}
	}
	public class MainThreadAction<T> : MainThreadAction, IChainAction<T>, IContinuableAction<T>, IFAction<T>, IFAction, IContinuableAction, IChainAction, IFollowAction, IFollowAction<T>
	{
		public T Result => default(T);

		public MainThreadAction(IContinuableAction<T> baseAction)
			: base((IContinuableAction)null)
		{
		}

		public MainThreadAction(Func<T> baseAction)
			: base((IContinuableAction)null)
		{
		}

		public bool TryInvoke(out T result)
		{
			result = default(T);
			return false;
		}
	}
}
