public class AdsTrackingDataController : NMSingleton<AdsTrackingDataController>
{
	private const string key = "ads_tracking";

	private AdsTracking _adsTracking;

	public AdsTracking AdsTracking => null;

	protected override void Init()
	{
	}

	public void SetDataToDefault()
	{
	}

	private void Save()
	{
	}

	private void OnWatchReward()
	{
	}

	public void UpdateDataFromServer(AdsTracking adsTracking)
	{
	}
}
