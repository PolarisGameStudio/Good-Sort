using System.Collections.Generic;
using Falcon.FalconAnalytics.Scripts.Enum;

public static class ResourceConstants
{
	public static Dictionary<ResourceType, string> resourceName;

	public const FlowType SOURCE = FlowType.Source;

	public const FlowType SINK = FlowType.Sink;

	public const string BUY_IAP = "iap";

	public const string WATCH_ADS = "ads";

	public static string GetResourceName(ResourceType resource)
	{
		return null;
	}
}
