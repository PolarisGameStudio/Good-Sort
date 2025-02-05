using UnityEngine;

public class IAPTrackingController : NMSingleton<IAPTrackingController>
{
	private const string key = "iap_tracking_";

	private IAPTracking _IAPtracking;

	public IAPTracking IAPtracking => null;

	public int ltv => 0;

	protected override void Init()
	{
	}

	public void SetDataToDefault()
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	private static void AutoInit()
	{
	}

	public int GetLTVBasedOnLimitPacks()
	{
		return 0;
	}

	private int GetLTVBasedOnDataStored()
	{
		return 0;
	}

	private void OnPurchaseSuccess(string obj)
	{
	}

	private void Save()
	{
	}

	public void UpdateDataFromServer(IAPTracking iAPTracking)
	{
	}
}
