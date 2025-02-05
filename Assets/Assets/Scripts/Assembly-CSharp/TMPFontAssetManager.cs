using System;
using TMPro;
using UnityEngine;

public class TMPFontAssetManager : PersistentSingleton<TMPFontAssetManager>
{
	[Serializable]
	public class Language
	{
		public string language;

		public TMP_FontAsset tMP_FontAsset;

		public void Set()
		{
		}
	}

	public static Action OnLocalize;

	public Language[] languages;

	public Material[] materialFonts;

	protected override void Awake()
	{
	}

	private void Update_Material()
	{
	}

	public Language GetLanguage()
	{
		return null;
	}
}
