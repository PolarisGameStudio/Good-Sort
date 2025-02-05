using UnityEngine;

public class PersistentHumbleSingleton<T> : MonoBehaviour where T : Component
{
	protected static T _instance;

	public float InitializationTime;

	public static bool HasInstance => false;

	public static T Current => null;

	public static T Instance => null;

	protected virtual void Awake()
	{
	}
}
