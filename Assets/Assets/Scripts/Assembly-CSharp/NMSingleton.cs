public abstract class NMSingleton<T> where T : class, new()
{
	private static T _instance;

	public static T instance => null;

	protected abstract void Init();
}
