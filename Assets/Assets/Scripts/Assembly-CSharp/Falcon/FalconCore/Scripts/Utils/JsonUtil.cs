using Newtonsoft.Json;

namespace Falcon.FalconCore.Scripts.Utils
{
	public static class JsonUtil
	{
		private static readonly JsonSerializerSettings Settings;

		public static T FromJson<T>(string jsonStr)
		{
			return default(T);
		}

		public static T FromJson<T>(string jsonStr, JsonSerializerSettings settings)
		{
			return default(T);
		}

		public static string ToJson(object obj)
		{
			return null;
		}

		public static string ToJson(object obj, JsonSerializerSettings settings)
		{
			return null;
		}
	}
}
