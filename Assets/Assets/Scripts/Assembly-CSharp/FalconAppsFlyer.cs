using System;

public static class FalconAppsFlyer
{
	private static string _appsflyerConversionData;

	private static string _appsflyerID;

	private static string _appsflyerAdgroupID;

	private static string _appsflyerOrigCost;

	private static string _appsflyerAfCostCurrency;

	private static bool _appsflyerIsFirstLaunch;

	private static string _appsflyerCampaignID;

	private static string _appsflyerAfCid;

	private static string _appsflyerMediaSource;

	private static string _appsflyerAdvertisingID;

	private static string _appsflyerAfStatus;

	private static string _appsflyerCostCentsUsd;

	private static string _appsflyerAfCostValue;

	private static string _appsflyerAfCostModel;

	private static string _appsflyerAfAD;

	private static bool _appsflyerIsRetargeting;

	private static string _appsflyerAdgroup;

	public static string AppsflyerAdvertisingID;

	private const string FALCON_APPSFLYER_CONVERSION_DATA = "falcon_analytics_appsflyer_conversion_data";

	public static Action onGetData;

	public static bool isGetData;

	public static string AppsflyerID => null;

	public static string AppsflyerAdgroupID => null;

	public static string AppsflyerOrigCost => null;

	public static string AppsflyerAfCostCurrency => null;

	public static bool AppsflyerIsFirstLaunch => false;

	public static string AppsflyerCampaignID => null;

	public static string AppsflyerAfCid => null;

	public static string AppsflyerMediaSource => null;

	public static string AppsflyerAfStatus => null;

	public static string AppsflyerCostCentsUsd => null;

	public static string AppsflyerAfCostValue => null;

	public static string AppsflyerAfCostModel => null;

	public static string AppsflyerAfAD => null;

	public static bool AppsflyerIsRetargeting => false;

	public static string AppsflyerAdgroup => null;

	private static void UpdateConvrersionData()
	{
	}

	public static void onConversionDataSuccess(string conversionData)
	{
	}
}
