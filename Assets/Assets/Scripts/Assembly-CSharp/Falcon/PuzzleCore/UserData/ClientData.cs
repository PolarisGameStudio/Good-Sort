using System;

namespace Falcon.PuzzleCore.UserData
{
	[Serializable]
	public class ClientData : AccountData
	{
		public GameInfo gameInfo;

		public ClientData()
		{
		}

		public ClientData(DeviceInfo deviceInfo, AccountInfo userInfo, GameInfo gameInfo, ApkInfo apkInfo, ThirdPartyData thirdPartyData)
		{
		}

		public ClientData(AccountData accountData)
		{
		}

		public void UpdateData(AccountData accountData)
		{
		}
	}
}
