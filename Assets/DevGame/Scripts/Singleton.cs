using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    private static T instance;

    public static bool IsInstanceInvalid()
    {
        return instance != null;
    }
    // IsInstanceInvalid()

    //void Awake() {
    //    singleton = gameObject.GetComponent<T>();
    //    DontDestroyOnLoad(this);
    //} // Awake ()

    public static T Instance
    {
        get
        {
            if (instance != null)
                return instance;

            instance = FindObjectOfType<T>();

            if (instance != null)
                return instance;
#if UNITY_EDITOR
            //Debug.LogError($"Not found Object for type {typeof(T).Name}");
#endif
            return instance;
        }


    } // Instance

    public static T TryGetInstance()
	{
		return null;
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}
}
