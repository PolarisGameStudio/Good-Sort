namespace Falcon
{
	public sealed class SocketClient
	{
		private static readonly SocketClient instance;

		private FSession activeSession;

		public static SocketClient Instance => null;

		static SocketClient()
		{
		}

		private SocketClient()
		{
		}

		public void SetActiveSession(FSession session)
		{
		}

		public void Send(CSMessage cSMessage, bool important)
		{
		}

		public FFuture Send(CSMessage cSMessage, FFuture fFuture, int timeOut = 5)
		{
			return null;
		}

		public void Send(CSMessage cSMessage)
		{
		}

		public FFuture Send(CSMessage cSMessage, FFuture future)
		{
			return null;
		}

		public string GetSessionId()
		{
			return null;
		}
	}
}
