using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup_UnlockCollection_CardSet_Item : MonoBehaviour
{
	public RectTransform rectItem;

	public SkeletonGraphic skeCard;

	public BoneFollowerGraphic boneSkecard;

	public SkeletonGraphic skeBorder;

	public Image iconCard;

	public Image iconHeadline;

	public TMPFontLocalize txtName;

	public TMPFontLocalize txtNamePremium;

	public RectTransform rectNew;

	private CardData c_data;

	public CardData GetData => null;

	public void SetItemData(CardData data, bool loadSprite)
	{
	}

	public void LoadSprite()
	{
	}

	public void Flip()
	{
	}

	public void Flip_Skip()
	{
	}

	public void New()
	{
	}
}
