using UnityEngine;

namespace Falcon.FalconCore.Scripts.Utils
{
	public class FFile
	{
		private static string _persistentDataPath;

		private readonly string fileName;

		public static string PersistentDataPath => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void OnStart()
		{
		}

		public FFile(string fileName)
		{
		}

		public void Save(object data)
		{
		}

		public void Save(string data)
		{
		}

		public void Append(object data)
		{
		}

		public void Append(string data)
		{
		}

		public T Load<T>()
		{
			return default(T);
		}

		public string Load()
		{
			return null;
		}

		private string GetFilePath()
		{
			return null;
		}

		public void Delete()
		{
		}
	}
}
