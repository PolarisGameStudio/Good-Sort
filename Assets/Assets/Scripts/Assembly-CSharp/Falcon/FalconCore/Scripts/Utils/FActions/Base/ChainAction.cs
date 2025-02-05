using System;

namespace Falcon.FalconCore.Scripts.Utils.FActions.Base
{
	public abstract class ChainAction : FAction, IChainAction, IContinuableAction, IFAction, IFollowAction
	{
		protected readonly IContinuableAction BaseAction;

		public override Exception Exception => null;

		public override bool Done => false;

		protected ChainAction(IContinuableAction baseAction)
		{
		}

		public override void Invoke()
		{
		}

		public override bool CanInvoke()
		{
			return false;
		}

		public override void Cancel()
		{
		}
	}
}
