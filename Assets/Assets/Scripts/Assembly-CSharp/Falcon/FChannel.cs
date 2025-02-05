namespace Falcon
{
	public abstract class FChannel
	{
		private FSession session;

		private string JWTToken;

		public abstract void Start();

		public abstract void Reconnect();

		public abstract void Disconnect();

		protected abstract void SendMessage(FMessage message);

		public void Send(FMessage message)
		{
		}

		public void OnConnected()
		{
		}

		public void OnDisconnected()
		{
		}

		public FSession GetSession()
		{
			return null;
		}

		public string GetJWTToken()
		{
			return null;
		}

		public void SetJWTToken(string token)
		{
		}

		public void SetSession(FSession session)
		{
		}

		public void OnMessage(FMessage message)
		{
		}
	}
}
