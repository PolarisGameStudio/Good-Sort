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

	public void AddResourceType()
	{
		switch ((ResourceType) type)
		{
			case ResourceType.Powerup_BreakItem:
				{
					HelperManager.DataPlayer.PowerBreakItem++;
					break;
				}
				
			case ResourceType.Powerup_Replace:
				{
                    HelperManager.DataPlayer.PowerReplay++;
                    break;
				}
				
			case ResourceType.Powerup_Freeze:
				{
                    HelperManager.DataPlayer.PowerFreeze++;
                    break;
				}
				
			case ResourceType.Powerup_Swap:
				{
                    HelperManager.DataPlayer.PowerSwap++;
                    break;
				}
				
			case ResourceType.Booster_X2_Star:
				{
                    HelperManager.DataPlayer.BoosterKindX2_Star++;
                    break;
				}
				
			case ResourceType.Booster_BreakItem:
				{
                    HelperManager.DataPlayer.BoosterKindBreakItem++;
                    break;
				}
				
			case ResourceType.Booster_Time:
				{
                    HelperManager.DataPlayer.BoosterKindIncreaseTime++;
                    break;
				}

        }
	}


    public ResourceValue()
	{
	}

	public ResourceValue(int type, float value)
	{
        this.type = type;
        this.value = value;
    }

	public ResourceValue(ResourceType type, float value)
	{
		this.type = (int)type;
		this.value = value;
    }
}
