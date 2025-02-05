using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public static class LoadTextureUtils
{

	private static Dictionary<string, Sprite> _dicAvatarUrl;

	private static Dictionary<string, Texture2D> _dicRawAvatarUrl;

	private static Sprite myAvatarFB;

	private const string key_my_avatar = "avatar_stored";

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	public static void RegisterEvent()
	{
	}

	public static void ReleasCacheAvatar()
	{
	}

	public static void LoadImageFromEncodeFileOrUrl(Image avatar, string urlAvatar)
	{
	}

	private static void SaveTextureToFile(Texture2D texture, string path)
	{
	}

	private static void LoadAvatarFromEncodeFile(Image avatar)
	{
	}

	public static void LoadAvatarFBFromDicOrWebRequest(Image image, string urlAvatar, GameObject target)
	{
	}

	public static void LoadRawAvatarFBFromDicOrWebRequest(RawImage rawImage, string urlAvatar, GameObject target)
	{
	}

	private static IEnumerator DownloadImageFromUrl(UnityWebRequest www, Image avatar, Action<Texture2D, Sprite> callback)
	{
		return null;
	}

	private static IEnumerator DownloadRawImageFromUrl(UnityWebRequest www, RawImage avatar, Action<Texture2D> callback)
	{
		return null;
	}

	public static IEnumerator DownloadAvatarTexture(UnityWebRequest www, Image avatar, Action<Texture2D, Sprite> actionSuccess = null, Action actionFailed = null)
	{
		return null;
	}

	public static IEnumerator DownloadRawAvatarTexture(UnityWebRequest www, RawImage avatar, Action<Texture2D> actionSuccess = null, Action actionFailed = null)
	{
		return null;
	}
}
