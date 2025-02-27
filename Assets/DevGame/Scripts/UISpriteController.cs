using UnityEngine;
using UnityEngine.UI;

public class UISpriteController : Singleton<UISpriteController>
{
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

	public void SetImageResource(ResourceType type, Image image, float scale = 1f)
	{
	}

	public void SetImageResource_Shop(ResourceType type, Image image, float scale = 1f)
	{
	}

	public float GetScale(ResourceType type)
	{
		return 0f;
	}

	public void SetImageAvatar(int id, Image image)
	{
	}

	public void SetMyImageAvatar(UserProfile userProfile, Image image)
	{
	}

	public void SetMyFacebookAvatar(UserProfile userProfile, RawImage rawImage)
	{
	}

	public void SetImageAvatar(UserProfile userProfile, Image image)
	{
	}

	public void SetRawImageAvatar(UserProfile userProfile, RawImage rawImage)
	{
	}

	public Sprite GetFrameAvatarProfile(bool isPremium)
	{
		return null;
	}

	public Sprite GetIconMasterPassChest(int index)
	{
		return null;
	}

	public Sprite GetGoldenGiftItem()
	{
		return null;
	}

	public int GetGoldenGiftId()
	{
		return 0;
	}

	public Sprite GetGoldenGiftItemForIngame()
	{
		return null;
	}

	public Sprite GetSpriteTeamIcon(int id)
	{
		return null;
	}

	protected override void OnDestroy()
	{
	}
}
