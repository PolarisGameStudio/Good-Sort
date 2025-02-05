using System;

namespace Falcon
{
	[Serializable]
	public class SCCloseSession : SCMessage
	{
		public int reason;

		public override string GetEvent()
		{
			return null;
		}

		public override void OnData()
		{
		}
	}
}
