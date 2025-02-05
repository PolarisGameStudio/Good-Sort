using System.Collections.Generic;
using Falcon.FalconAnalytics.Scripts.Enum;

public static class FalconDWHLog
{
	private const string DIFF = "easy";

	public static void AdsLog(string where, AdType adType)
	{
	}

	public static void InappLog(string productId, string currencyCode, string price, decimal priceDecimal, string transactionId, string purchaseToken, string payLoad, string where)
	{
	}

	private static string GetCurrentEvent()
	{
		return null;
	}

	public static void SessionLog(int sessionTime, string gameMod)
	{
	}

	public static void PropertyLog(string name, string value)
	{
	}

	public static void EventLog(string eventName, Dictionary<string, object> param = null)
	{
	}

	public static void LevelLog(int level, int duration, int wave, LevelStatus status, string detail)
	{
	}

	public static void ResourceLog(FlowType flowType, string itemType, string itemId, ResourceValue resourceValue, long valueBefores, long valueAfters)
	{
	}
}
