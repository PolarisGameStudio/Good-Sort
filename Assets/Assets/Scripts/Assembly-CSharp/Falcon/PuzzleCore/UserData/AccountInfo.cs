using System;

namespace Falcon.PuzzleCore.UserData
{
	[Serializable]
	public class AccountInfo
	{
		public int code;

		public string token;

		public int accountId;

		public string device_id;

		public string fb_id;

		public string google_id;

		public string apple_id;

		public string advertising_id;

		public string bind_type;

		public string bind_id;

		public string bind_data;

		public string uuid;

		public string country;

		public string country_code;

		public AccountInfo()
		{
		}

		public AccountInfo(string device_id, string advertising_id)
		{
		}
	}
}
