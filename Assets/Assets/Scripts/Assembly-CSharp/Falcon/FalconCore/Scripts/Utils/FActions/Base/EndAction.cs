using System;

namespace Falcon.FalconCore.Scripts.Utils.FActions.Base
{
	public abstract class EndAction : FAction, IEndAction, IFollowAction, IFAction
	{
		protected readonly IContinuableAction BaseAction;

		public override Exception Exception => null;

		public override bool Done => false;

		protected EndAction(IContinuableAction baseAction)
		{
		}

		public override void Invoke()
		{
		}

		public override bool CanInvoke()
		{
			return false;
		}
	}
}
