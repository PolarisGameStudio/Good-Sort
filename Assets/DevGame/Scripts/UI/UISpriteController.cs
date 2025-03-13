using UnityEngine;
using UnityEngine.UI;

public class UISpriteController : MonoBehaviour
{
	public static UISpriteController Instance;

    public SO_SpriteResource resource;

	public SO_SpriteResource resource_shop;

	public SO_SpriteResource resource_headline;

	public SO_SpriteAvatar avatar;

	public SO_SpriteCollection collection;

	[Header("Master Pass")]
	public Sprite[] sprBoosterIconLocks;

	[Header("Master Pass")]
	public Sprite[] sprFrameAvatarMasterPass;

	public Sprite[] sprMasterPassChests;

	[Header("Golden Gift")]
	public Sprite[] sprGoldenGiftItems;

	public Sprite[] sprGoldenGiftItemsForInGame;

	[Header("Team Icon")]
	public Sprite[] sprTeamIcons;

	public Sprite sprNoTeamIcon;

    private void Awake()
    {
		if(Instance != null)
		{
			Destroy(this.gameObject);
			return;
		}

		Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public float GetScale(ResourceType type)
	{
		return 0f;
	}

	public Sprite GetFrameAvatarProfile(bool isPremium)
	{
		return null;
	}

	public Sprite GetIconMasterPassChest(int index)
	{
		foreach(var item in resource_headline.icons)
		{
			if ((ResourceType)index == item.type)
			{
				return item.spr;
			}
		}
		return null;
	}

	public Sprite GetGoldenGiftItemForIngame()
	{
		return null;
	}

	public Sprite GetSpriteTeamIcon(int id)
	{
		return null;
	}

	public Sprite GetSpriteResource(ResourceType kind)
	{
		return resource.GetIcon(kind);
    }
	
}
