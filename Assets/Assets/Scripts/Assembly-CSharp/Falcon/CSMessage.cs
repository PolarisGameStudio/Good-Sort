using System;

namespace Falcon
{
	[Serializable]
	public abstract class CSMessage : FMessage
	{
		public enum TransportType
		{
			TCP = 0,
			UDP = 1
		}

		public void Send()
		{
		}

		public void Send(bool important)
		{
		}

		public FFuture Send(FFuture future, int timeOut)
		{
			return null;
		}

		public FFuture Send(FFuture future)
		{
			return null;
		}

		public void Send(TransportType transportType)
		{
		}

		public void Broadcast(string roomId)
		{
		}

		public void Broadcast(string roomId, TransportType transportType)
		{
		}
	}
}
