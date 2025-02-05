using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Falcon.FalconAnalytics.Scripts.Enum
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LevelStatus
	{
		Fail = 0,
		Pass = 1,
		ReplayPass = 2,
		ReplayFail = 3,
		Skip = 4
	}
}
