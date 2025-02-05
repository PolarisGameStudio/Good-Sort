using UnityEngine;

namespace Falcon.FalconCore.Scripts.Repositories.News
{
	public static class FDeviceInfoRepo
	{
		public static string PackageName { get; private set; }

		public static string GameName { get; private set; }

		public static string Platform { get; private set; }

		public static string AppVersion { get; private set; }

		public static string SdkCoreVersion { get; private set; }

		public static string DeviceName { get; private set; }

		public static string DeviceId { get; private set; }

		public static string DeviceOs { get; private set; }

		public static string DeviceModel { get; private set; }

		public static int ScreenWidth { get; private set; }

		public static int ScreenHeight { get; private set; }

		public static float ScreenDpi { get; private set; }

		public static string DeviceGpu { get; private set; }

		public static string DeviceCpu { get; private set; }

		public static string Language { get; private set; }

		static FDeviceInfoRepo()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void Init()
		{
		}

		private static string GetDeviceId()
		{
			return null;
		}

		private static string CreateUniqueString()
		{
			return null;
		}
	}
}
