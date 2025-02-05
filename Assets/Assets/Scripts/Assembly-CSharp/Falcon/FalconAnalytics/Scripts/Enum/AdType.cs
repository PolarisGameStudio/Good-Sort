using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Falcon.FalconAnalytics.Scripts.Enum
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AdType
	{
		Banner = 0,
		Interstitial = 1,
		Reward = 2,
		AppOpen = 3,
		Native = 4
	}
}
