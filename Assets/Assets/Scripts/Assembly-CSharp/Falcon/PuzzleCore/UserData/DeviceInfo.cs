using System;

namespace Falcon.PuzzleCore.UserData
{
	[Serializable]
	public class DeviceInfo
	{
		public string deviceModel;

		public string operatingSystem;

		public string systemLanguage;

		public string systemLanguageISO;

		public string resolution;

		public int deviceMemory;

		public int graphicsMemorySize;

		public string platform;
	}
}
