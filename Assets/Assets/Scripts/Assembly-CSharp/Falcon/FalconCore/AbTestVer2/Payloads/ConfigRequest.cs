using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Falcon.FalconCore.AbTestVer2.Payloads
{
	[Serializable]
	public class ConfigRequest
	{
		[JsonIgnore]
		private const string ServerURL = "https://gateway.data4game.com/kapigateway/abtestingservice/sdk-request/get-config";

		public string runningAbTesting;

		public string packageName;

		public Dictionary<string, object> abTestingConfigs;

		public Dictionary<string, bool> campaignMeta;

		public Dictionary<string, object> properties;

		public ConfigResponse Connect()
		{
			return null;
		}
	}
}
