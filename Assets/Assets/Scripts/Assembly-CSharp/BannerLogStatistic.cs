using System.Collections.Generic;
using Falcon.FalconAnalytics.Scripts.Payloads.Flex;
using Falcon.FalconCore.Scripts.Utils.Entities;
using Falcon.FalconCore.Scripts.Utils.Singletons;

public class BannerLogStatistic : FSingleton<BannerLogStatistic>
{
	private struct BannerKey
	{
		public string AdWhere { get; }

		public string AdPrecision { get; }

		public string AdCountry { get; }

		public string AdNetwork { get; }

		public string AdMediation { get; }

		public BannerKey(string adWhere, string adPrecision, string adCountry, string adNetwork, string adMediation)
		{
			AdWhere = null;
			AdPrecision = null;
			AdCountry = null;
			AdNetwork = null;
			AdMediation = null;
		}
	}

	private struct BannerValue
	{
		public double AdRev { get; private set; }

		public double? AdLtv { get; private set; }

		public void Update(double adRev, double? adLtv)
		{
		}
	}

	private readonly FConcurrentDict<BannerKey, BannerValue> cache;

	static BannerLogStatistic()
	{
	}

	public void Log(string adWhere, string adPrecision, string adCountry, double adRev, string adNetwork, string adMediation, double? adLtv = null)
	{
	}

	private List<DataWrapper> FlushCountMap()
	{
		return null;
	}
}
