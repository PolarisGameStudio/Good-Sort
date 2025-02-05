using System;
using GoogleMobileAds.Ump.Api;

public static class ConsentPopup
{
	public static Action onError;

	public static Action onShow;

	public static Action onUpdate;

	public static void Reset()
	{
	}

	public static void Start()
	{
	}

	private static void OnConsentInfoUpdated(FormError consentError)
	{
	}
}
