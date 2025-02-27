using System;
using UnityEngine;
using UnityEngine.UI;

public class SO_SpriteCollection : ScriptableObject
{
	[Serializable]
	public class Topic
	{
		public string name;

		//public AssetReferenceSprite[] cardsRef;
	}

	public Topic[] topics;

	public Sprite[] sprFeatureSets;

	public Sprite[] sprTagNumbers;

	public Sprite[] sprHeadlines;

	public Material[] matFontTextHeadlines;

	public Sprite GetCard(int set, int indexCard)
	{
		return null;
	}

	public void SetCardToImage(int set, int indexCard, Image image)
	{
	}

	public void ReleaseAsset()
	{
	}

	public Sprite GetFeatureSets(int set)
	{
		return null;
	}

	public Sprite GetTagNumbers(int set)
	{
		return null;
	}

	public Sprite GetHeadlines(int set)
	{
		return null;
	}

	public Material GetMaterialHeadlines(int set)
	{
		return null;
	}
}
