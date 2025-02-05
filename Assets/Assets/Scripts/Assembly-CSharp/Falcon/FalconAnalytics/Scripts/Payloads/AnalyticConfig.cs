using System;
using Falcon.FalconCore.Scripts.FalconABTesting.Scripts.Model;

namespace Falcon.FalconAnalytics.Scripts.Payloads
{
	[Serializable]
	public class AnalyticConfig : FalconConfig
	{
		public bool fCoreAnalyticShouldNotSendLogToServer;

		public bool fCoreAnalyticTesting;

		public string fCoreAnalyticTestingSingleUrl;

		public string fCoreAnalyticTestingBatchUrl;
	}
}
