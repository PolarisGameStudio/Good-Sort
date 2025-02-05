using System;

namespace Falcon
{
	[Serializable]
	public class SCInitSession : SCMessage
	{
		public const int STATE_NEW_SESSION = 0;

		public const int STATE_OLD_SESSION = 1;

		public int state;

		public override string GetEvent()
		{
			return null;
		}

		public override void OnData()
		{
		}

		public int GetState()
		{
			return 0;
		}
	}
}
