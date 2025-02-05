namespace Falcon
{
	public interface ISession
	{
		void OnChannelConnected();

		void OnChannelDisconnected();

		void OnMessage(FMessage message);

		void Send(FMessage message);

		void SetTimeout(int sec);

		void NewSession();

		void Start();

		void ContinueCurrentSession();

		void Close();
	}
}
