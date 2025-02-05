using System;

namespace Falcon
{
	[Serializable]
	public class CSSCResponse : SCMessage
	{
		public bool success;

		public string code;

		public string message;

		public override string GetEvent()
		{
			return null;
		}

		public override void OnData()
		{
		}

		public CSSCResponse()
		{
		}

		public CSSCResponse(string messageId, bool success, string message, string code)
		{
		}
	}
}
