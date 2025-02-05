using System;
using Falcon.FalconCore.Scripts.Utils.FActions.Base;

namespace Falcon.FalconCore.Scripts.Utils.FActions.Variances.Ends
{
	public class RepeatAction : EndAction
	{
		private long invokableTime;

		private bool cancel;

		public TimeSpan TimeSpan { get; set; }

		public RepeatAction(IContinuableAction baseAction, TimeSpan timeSpan)
			: base(null)
		{
		}

		public RepeatAction(Action action, TimeSpan timeSpan)
			: base(null)
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
