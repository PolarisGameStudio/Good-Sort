using UnityEngine;

public static class UI_CacheResource
{
	private static int _preStar;

	private static int _curStar;

	private static int _preGold;

	private static int _curGold;

	public static int PreStar => 0;

	public static int CurStar => 0;

	public static int PreGold => 0;

	public static int CurGold => 0;

	public static bool IsWinLevel => false;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
	public static void InitListener()
	{
	}

	private static void OnChangeScene(SceneState state)
	{
	}

	public static void ConfirmUpdate()
	{
	}
}
