using UnityEngine;

public class LazySingleton<T> : MonoBehaviour where T : Component
{
	protected static T _instance;

	public static T Instance => null;

	public static bool HaveInstance()
	{
		return false;
	}

	protected virtual void OnDestroy()
	{
	}
}
