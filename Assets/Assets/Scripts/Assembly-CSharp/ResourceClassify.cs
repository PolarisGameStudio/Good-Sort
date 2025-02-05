using System.Collections.Generic;

public static class ResourceClassify
{
	public static readonly List<ResourceType> ResourcePowerup;

	public static readonly Dictionary<PowerupKind, ResourceType> DicResourcePowerup;

	public static readonly List<ResourceType> ResourceBooster;

	public static readonly Dictionary<BoosterKind, ResourceType> DicResourceBooster;

	public static readonly Dictionary<ResourceType, CollectionPack> DicCollectionPack;

	public static ResourceType GetRandomPowerup()
	{
		return default(ResourceType);
	}

	public static ResourceType GetRandomBooster()
	{
		return default(ResourceType);
	}
}
