using System;

namespace Falcon.PuzzleCore.UserData
{
	[Serializable]
	public class BindData
	{
		public string fb_id;

		public string google_id;

		public string apple_id;

		public string avatar_url;

		public BindData(string fb_id = "", string google_id = "", string apple_id = "", string avatar_url = "")
		{
		}
	}
}
