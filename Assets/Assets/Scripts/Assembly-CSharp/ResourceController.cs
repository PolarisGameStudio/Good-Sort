using System;
using System.Collections.Generic;

public class ResourceController : NMSingleton<ResourceController>
{
	public Action<ResourceValue> OnAddResource;

	protected override void Init()
	{
	}

	public bool IsX2Reward()
	{
		return false;
	}

	public TimeSpan GetTimeX2Reward()
	{
		return default(TimeSpan);
	}

	public void AddResource(ResourceValue resourceValue, string itemType, string itemId)
	{
	}

	public void AddResource(List<ResourceValue> resourceValues, string itemType, string itemId)
	{
	}
}
