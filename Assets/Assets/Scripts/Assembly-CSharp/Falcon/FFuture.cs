using System;

namespace Falcon
{
	public class FFuture
	{
		public static FFuture RECEIVED;

		public static FFuture PROCESSED;

		public Action<CSSCResponse> onResponse;

		private int timeOut;

		private long timeSend;

		private string messageId;

		public FFuture()
		{
		}

		public FFuture(string messageId, int timeOut)
		{
		}

		public int GetTimeOut()
		{
			return 0;
		}

		public long GetTimeSend()
		{
			return 0L;
		}

		public string GetMessageId()
		{
			return null;
		}

		public void AddActionOnResponse(Action<CSSCResponse> onResponse)
		{
		}

		public void OnResponse(CSSCResponse response)
		{
		}

		public void OnTimeout()
		{
		}
	}
}
