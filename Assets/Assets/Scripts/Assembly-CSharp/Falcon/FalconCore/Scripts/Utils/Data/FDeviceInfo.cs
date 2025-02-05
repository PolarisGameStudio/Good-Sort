using System;

namespace Falcon.FalconCore.Scripts.Utils.Data
{
	[Obsolete("Use FDeviceInfoRepo instead")]
	public static class FDeviceInfo
	{
		public static string GameId => null;

		public static string GameName => null;

		public static string Platform => null;

		public static string AppVersion => null;

		public static string SdkCoreVersion => null;

		public static string DeviceName => null;

		public static string DeviceId => null;

		public static DateTime FirstLogInDateTime => default(DateTime);

		public static long FirstLogInMillis => 0L;
	}
}
