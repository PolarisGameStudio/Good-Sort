using System;
using Falcon.FalconCore.Scripts.Utils.FActions.Base;

namespace Falcon.FalconCore.Scripts.Utils.FActions.Variances.Ends
{
	public class ScheduleAction : EndAction
	{
		private long invokableTime;

		private bool cancel;

		public TimeSpan TimeSpan { get; set; }

		public ScheduleAction(IContinuableAction baseAction, TimeSpan timeSpan)
			: base(null)
		{
		}

		public ScheduleAction(Action action, TimeSpan timeSpan)
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
