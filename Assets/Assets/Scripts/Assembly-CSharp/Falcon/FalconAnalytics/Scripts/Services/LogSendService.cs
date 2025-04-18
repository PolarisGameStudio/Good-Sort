using Falcon.FalconAnalytics.Scripts.Models.Messages.Interfaces;
using Falcon.FalconCore.Scripts.Utils.Entities;
using Falcon.FalconCore.Scripts.Utils.FActions.Variances.Ends;
using Falcon.FalconCore.Scripts.Utils.Singletons;

namespace Falcon.FalconAnalytics.Scripts.Services
{
	public class LogSendService : FSingleton<LogSendService>
	{
		private const string CachedRequestList = "Request_Queue";

		private readonly RepeatAction flushing;

		private readonly FLimitQueue<IDataLog> waitingQueue;

		private void FlushQueue()
		{
		}

		private void SaveRequest()
		{
		}

		private void LoadRequests()
		{
		}

		public void Enqueue(IDataLog wrapper)
		{
		}
	}
}
