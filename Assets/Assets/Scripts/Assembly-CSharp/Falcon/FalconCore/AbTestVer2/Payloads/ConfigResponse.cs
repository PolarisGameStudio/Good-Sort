using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace Falcon.FalconCore.AbTestVer2.Payloads
{
	[Serializable]
	public class ConfigResponse
	{
		public string runningAbTesting;

		public string[] abTestingFields;

		public Dictionary<string, bool> campaignMeta;

		public Dictionary<string, object> configs;

		public string[] AbTestingField => null;

		public Dictionary<string, bool> CampaignMeta => null;

		public Dictionary<string, object> Configs => null;

		[Preserve]
		public ConfigResponse()
		{
		}

		public Dictionary<string, object> TestingConfigs()
		{
			return null;
		}

		public Dictionary<string, object> NonTestConfigs()
		{
			return null;
		}
	}
}
