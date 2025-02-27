using System;
using UnityEngine;

public class SO_SpriteResource : ScriptableObject
{
	[Serializable]
	public class Icon
	{
		public ResourceType type;

		public Sprite spr;
	}

	public Icon[] icons;

	public Sprite GetIcon(ResourceType type)
	{
		return null;
	}
}
