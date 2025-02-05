using System;

namespace Falcon
{
	public class FSocketIOChannel : FChannel
	{

		private string uri;

		private Func<object, object> OnStartListening;

		public FSocketIOChannel(string uri)
		{
		}

		public override void Reconnect()
		{
		}

		public override void Start()
		{
		}

		
		protected override void SendMessage(FMessage message)
		{
		}

		public override void Disconnect()
		{
		}
	}
}
