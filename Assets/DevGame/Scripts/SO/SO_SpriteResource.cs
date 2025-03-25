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
		foreach(var it in icons)
		{
			if(it.type == type)
			{
				return it.spr;
			}
		}

		int kk = 0;

		return null;
	}
}
