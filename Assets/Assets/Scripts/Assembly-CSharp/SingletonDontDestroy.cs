using UnityEngine;

public class SingletonDontDestroy<T> : MonoBehaviour where T : Component
{
	protected static T _instance;

	public static bool IsNull => false;

	public static T Instance => null;

	protected virtual void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
