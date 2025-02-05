using System;

namespace Falcon
{
	[Serializable]
	public class CSInitSession : CSMessage
	{
		public string sessionId;

		public CSInitSession(string sessionId)
		{
		}

		public override string GetEvent()
		{
			return null;
		}
	}
}
