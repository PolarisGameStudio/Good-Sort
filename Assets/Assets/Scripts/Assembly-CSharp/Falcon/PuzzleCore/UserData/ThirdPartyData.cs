using System;

namespace Falcon.PuzzleCore.UserData
{
	[Serializable]
	public class ThirdPartyData
	{
		public FirebaseData firebase_data;

		public AppsFlyerData appsflyer_data;

		public ThirdPartyData(FirebaseData firebase_data, AppsFlyerData appsflyer_data)
		{
		}

		public ThirdPartyData()
		{
		}
	}
}
