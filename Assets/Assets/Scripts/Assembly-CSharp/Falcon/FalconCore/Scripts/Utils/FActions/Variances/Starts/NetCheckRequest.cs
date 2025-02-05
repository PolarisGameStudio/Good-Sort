using System;
using Falcon.FalconCore.Scripts.Utils.FActions.Base;

namespace Falcon.FalconCore.Scripts.Utils.FActions.Variances.Starts
{
	public class NetCheckRequest : StartAction, IStartAction<bool>, IContinuableAction<bool>, IFAction<bool>, IFAction, IContinuableAction, IStartAction
	{
		private Exception exception;

		private bool isDone;

		public int TimeoutMs { get; set; }

		public override Exception Exception => null;

		public override bool Done => false;

		public bool Result { get; private set; }

		public bool InvokeAndGet()
		{
			return false;
		}

		public override void Invoke()
		{
		}
	}
}
