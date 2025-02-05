namespace Falcon.FalconCore.Scripts.Utils.Singletons
{
	public class FSingleton<T> where T : FSingleton<T>, new()
	{
		private static T _instance;

		public static T Instance => null;

		protected FSingleton()
		{
		}
	}
}
