using System;
using System.Collections.Generic;
using Falcon.FalconCore.AbTestVer2.Payloads;

namespace Falcon.FalconCore.AbTestVer2.Repositories
{
	public static class FConfigRepo
	{
		private const string Config = "FALCON_CONFIG_VER_2_";

		private static ConfigResponse _response;

		private static Lazy<Dictionary<string, object>> _configs;

		private static Lazy<Dictionary<string, object>> _nonTestConfigs;

		private static Lazy<Dictionary<string, object>> _testingConfigs;

		public static string RunningAbTesting => null;

		public static Dictionary<string, object> Configs => null;

		public static Dictionary<string, object> NonTestConfigs => null;

		public static Dictionary<string, object> TestingConfigs => null;

		public static Dictionary<string, bool> CampaignMeta => null;

		public static void Save(ConfigResponse config)
		{
		}
	}
}
