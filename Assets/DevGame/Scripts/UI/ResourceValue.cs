using System;

[Serializable]
public class ResourceValue
{
	public int type;

	public float value;

	public ResourceType GetTypeEnum()
	{
		return default(ResourceType);
	}

	public ResourceValue()
	{
	}

	public ResourceValue(int type, float value)
	{
	}

	public ResourceValue(ResourceType type, float value)
	{
	}
}
