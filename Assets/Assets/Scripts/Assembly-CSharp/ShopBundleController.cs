using System;
using System.Collections.Generic;

public class ShopBundleController : NMSingleton<ShopBundleController>
{
	public static int shopBundleType;

	private Dictionary<BundleType, List<ResourceValue>> _dicBundleValue;

	public Action<BundleType> onBuyComplete;

	protected override void Init()
	{
	}

	private void OnChangeScene(SceneState state)
	{
	}

	private void CheckShopBundleTypeFromRemoteConfig()
	{
	}

	public List<ResourceValue> GetResources(BundleType bundleType)
	{
		return null;
	}

	public List<ResourceValue> GetResourceValues(BundleType bundleType)
	{
		return null;
	}

	private string GetBundleName(BundleType bundleType)
	{
		return null;
	}

	public string GetPrice(BundleType bundleType)
	{
		return null;
	}

	public void Purchase(BundleType bundleType)
	{
	}
}
