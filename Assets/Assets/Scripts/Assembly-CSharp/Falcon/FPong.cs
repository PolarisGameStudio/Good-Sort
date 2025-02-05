using System;

namespace Falcon
{
	[Serializable]
	public class FPong : SCMessage
	{
		public override string GetEvent()
		{
			return null;
		}

		public override void OnData()
		{
		}
	}
}
