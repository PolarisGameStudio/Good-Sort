namespace Falcon
{
	public interface ISessionListener
	{
		void OnChannelConnected(FSession session);

		void OnChannelDisconnected(FSession session);

		void OnTimeout(FSession session);

		void OnNewSession(FSession session);

		void OnContinueCurrentSession(FSession session);

		void onFirstSession(FSession fSession);
	}
}
