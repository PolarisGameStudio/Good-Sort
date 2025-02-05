using System.Collections.Generic;

public static class LogAppsFlyer
{
	public static void LogEvent(string eventName, Dictionary<string, string> eventValues)
	{
	}

	public static void LogEvent(string eventName)
	{
	}

	public static void TrackAppflyerPurchase(string sku)
	{
	}

	public static void LogAppflyerPurchase(string eventName, int purchaseCounter)
	{
	}

	public static float GetLocalizedPrice(string sku)
	{
		return 0f;
	}

	public static string GetCurrencyCode(string sku)
	{
		return null;
	}
}
